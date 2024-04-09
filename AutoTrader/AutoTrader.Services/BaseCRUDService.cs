using System;
using AutoMapper;
using AutoTrader.Model;
using AutoTrader.Model.Requests;
using AutoTrader.Model.SearchObjects;
using AutoTrader.Services.Database;
using AutoTrader.Services.Helpers;

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
                var salt = PasswordHelper.GenerateSalt();
                var hash = PasswordHelper.GenerateHash(salt, userRequest.Password);
                user.PasswordHash = hash;
                user.PasswordSalt = salt;
            }

            if (entity is AutomobileAd && request is AutomobileAdInsertRequest Request)
            {
                var automobileAd = entity as AutomobileAd;
                automobileAd.DateOFadd = DateTime.UtcNow;

                if (Request.ImagesFiles != null)
                {
                    string folder = "AutomobileAd/Images/";
                    Request.AdImages = new List<Model.AdImage>();

                    foreach (var file in Request.ImagesFiles)
                    {
                        var images = new Model.AdImage()
                        {
                            Name = file.Name,
                            URL = await UploadImage(folder, file)
                        };
                        Request.AdImages.Add(images);
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



        private async Task<string> UploadImage(string folderPath, Microsoft.AspNetCore.Http.IFormFile file)
        {
            folderPath += Guid.NewGuid().ToString() + "_" + file.Name;

            string serverFolder = Path.Combine("wwwroot", folderPath);

            await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));

            return "/" + folderPath;
        }



    }

}

