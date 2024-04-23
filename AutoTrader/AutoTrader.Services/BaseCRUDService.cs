using System;
using System.Net.NetworkInformation;
using AutoMapper;
using AutoTrader.Model;
using AutoTrader.Model.Requests;
using AutoTrader.Model.SearchObjects;
using AutoTrader.Services.Database;
using AutoTrader.Services.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.IdentityModel.Tokens;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;
using Microsoft.Extensions.FileProviders;
using AutoTrader.Services.Migrations;

namespace AutoTrader.Services
{
    public class BaseCRUDService<T, TDb, TSearch, TInsert, TUpdate> : BaseService<T, TDb, TSearch> where TDb : class where T : class where TSearch : BaseSearchObject
    {



        public BaseCRUDService(AutoTraderContext context, IMapper mapper) : base(context, mapper)

        {


        }

        public virtual async Task<T> Insert(TInsert request)
        {
            var entity = _mapper.Map<TDb>(request);

            if (entity is Database.User user && request is UsersInsertRequests userRequest)

            {

                byte[] profilePictureBytes = await ProcessProfilePicture(userRequest.ProfilePictureUrl);

                if (profilePictureBytes != null)
                {
                    user.ProfilePicture = profilePictureBytes;
                    user.ProfilePictureUrl = userRequest.ProfilePictureUrl;
                }

                if (userRequest.ProfilePictureUrl == null)
                {
                    user.ProfilePictureUrl = "https://img.freepik.com/free-vector/illustration-businessman_53876-5856.jpg?size=626&ext=jpg&ga=GA1.1.1700460183.1712880000&semt=ais";
                }

                var salt = PasswordHelper.GenerateSalt();
                var hash = PasswordHelper.GenerateHash(salt, userRequest.Password);
                user.PasswordHash = hash;
                user.PasswordSalt = salt;
            }

            if (entity is AutomobileAd && request is AutomobileAdInsertRequest Request)
            {
                var automobileAd = entity as AutomobileAd;
                automobileAd.DateOFadd = DateTime.UtcNow;


                if (Request.Images != null && Request.Images.Any())
                {

                    int automobileId = automobileAd.Id;

                    foreach (var imageFile in Request.Images)
                    {

                        string imageUrl = await ConvertImageToBase64(imageFile);


                        var adImage = new Services.Database.AdImage
                        {
                            URL = imageUrl,
                            AutomobileAdId = automobileId
                        };


                        automobileAd.Images.Add(adImage);
                    }
                }


            }


            _context.Set<TDb>().Add(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<T>(entity);
        }


        public virtual async Task<T> Update(int id, TUpdate request)
        {
            var entity = await _context.Set<TDb>().FindAsync(id);
            if (entity == null)
            {

                return null;
            }
            _mapper.Map(request, entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<T>(entity);
        }

        public virtual async Task<T> Delete(int id)
        {
            var entity = await _context.Set<TDb>().FindAsync(id);
            if (entity == null)
            {
                return null;
            }

            _context.Set<TDb>().Remove(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<T>(entity);
        }


        public async Task<string> ConvertImageToBase64(IFormFile imageFile)
        {
            using (var memoryStream = new MemoryStream())
            {
                await imageFile.CopyToAsync(memoryStream);
                byte[] bytes = memoryStream.ToArray();
                string base64String = Convert.ToBase64String(bytes);
                return base64String;
            }
        }

        //private async Task<string> SaveImage(IFormFile imageFile)
        //{
        //    var uniqueFileName = $"{Guid.NewGuid()}{Path.GetExtension(imageFile.FileName)}";
        //    var uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images");
        //    var filePath = Path.Combine(uploadFolder, uniqueFileName);

        //    Directory.CreateDirectory(uploadFolder);

        //    using (var stream = new FileStream(filePath, FileMode.Create))
        //    {
        //        await imageFile.CopyToAsync(stream);
        //    }

        //    return $"/Images/{uniqueFileName}";
        //}



        private async Task<byte[]> ProcessProfilePicture(string profilePictureUrl)
        {
            if (string.IsNullOrEmpty(profilePictureUrl))
            {
                return null;
            }

            byte[] profilePictureBytes;

            // Provjera da li je korisnik unio URL slike
            if (Uri.TryCreate(profilePictureUrl, UriKind.Absolute, out Uri imageUrl) &&
                (imageUrl.Scheme == Uri.UriSchemeHttp || imageUrl.Scheme == Uri.UriSchemeHttps))
            {
                // Preuzimanje slike s URL-a
                using (var client = new System.Net.WebClient())
                {
                    profilePictureBytes = await client.DownloadDataTaskAsync(profilePictureUrl);
                }
            }
            else
            {
                // Ako nije unesen URL slike, pretpostavite da je to base64 string
                try
                {
                    profilePictureBytes = Convert.FromBase64String(profilePictureUrl);
                }
                catch (FormatException ex)
                {
                    throw new ArgumentException("Invalid base64 string for picture.", ex);
                }
            }

            return profilePictureBytes;
        }



    }

}

