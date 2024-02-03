using System;
namespace AutoTrader.Services.Database
{
	public partial class User
	{
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public string Gender { get; set; }
        public string PasswordHash { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte[] ProfilePicture { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }
    }
}

