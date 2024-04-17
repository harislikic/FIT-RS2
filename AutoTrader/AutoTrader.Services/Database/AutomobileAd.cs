using System;
using AutoTrader.Services.Database;

namespace AutoTrader.Services
{
	public partial class AutomobileAd

    {
		public int Id { get; set;}
		public string Title { get; set; }
        public string Description { get; set; }
        public double? Price { get; set; }

        public DateTime? DateOFadd { get; set; }
        public int ViewsCount { get; set; }

        public string YearOfManufacture { get; set; }
   
        public bool Registered { get; set; }
        public DateTime? RegistrationExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsApproved { get; set; }
        public bool IsFeatured { get; set; } 
        public DateTime? FeaturedExpiryDate { get; set; }

        public DateTime Last_Small_Service { get; set; }

        public DateTime Last_Big_Service { get; set; }

        public string Milage { get; set; }

        public ICollection<AdImage>? Images { get; set; }

        public int AdditionalEquipmentId { get; set; }
        public AdditionalEquipment AdditionalEquipment { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int FuelTypeId { get; set; }
        public FuelType FuelType { get; set; }

        public int TransmissionTypeId { get; set; }
        public TransmissionType TransmissionType { get; set; }

        public int VehicleConditionId { get; set; }
        public VehicleCondition VehicleCondition { get; set; }

        public int CarBrandId { get; set; }
        public CarBrand CarBrand { get; set; }

        public int CarModelId { get; set; }
        public CarModel CarModel { get; set; }


        public int CarCategoryId { get; set; }
        public CarCategory CarCategory { get; set; }

    }
}