using System;
using AutoTrader.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace AutoTrader.Services.Database
{
	public partial class AutoTraderContext : DbContext
    {

        public AutoTraderContext () : base() { }

        public AutoTraderContext(DbContextOptions<AutoTraderContext> options) : base(options)
        {
		}

        public  DbSet<User> Users { get; set; }

        public  DbSet<AutomobileAd> AutomobileAds { get; set; }

        public  DbSet<VehicleCondition> VehicleConditions { get; set; }

        public  DbSet<TransmissionType> TransmissionTypes { get; set; }

        public  DbSet<FuelType> FuelTypes { get; set; }

        public  DbSet<Comment> Comments { get; set; }

        public  DbSet<City> Cities { get; set; }

        public  DbSet<CarModel> CarModels { get; set; }

        public  DbSet<CarCategory> carCategories { get; set; }

        public  DbSet<CarBrand> CarBrands { get; set; }

        public  DbSet<Canton> Cantons { get; set; }

        public  DbSet<AdImage> AdImages { get; set; }

        public  DbSet<MaintenanceServie> MaintenanceServies { get; set; }

        public DbSet<AdditionalEquipment> AdditionalEquipments { get; set; }

        public  DbSet<Reservation> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         optionsBuilder.UseSqlServer("Data Source=localhost,1401;Initial Catalog=AutoTraderTest; user=sa; Password=warcraft12345; TrustServerCertificate=True;");
        }
    }
}

