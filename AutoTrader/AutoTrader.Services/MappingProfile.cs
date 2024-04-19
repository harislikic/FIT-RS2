using System;
using AutoMapper;
using AutoTrader.Model.Requests;
using AutoTrader.Services.Database;

namespace AutoTrader.Services
{
	public class MappingProfile : Profile
	{
        public MappingProfile()
        {

            CreateMap<User, Model.User>();
            CreateMap<UsersInsertRequests,User>();
            CreateMap<UsersUpdateRequest,User>();

            CreateMap<AdImage, Model.AdImage>();


            CreateMap<AutomobileAd, Model.AutomobileAd>();
            CreateMap<AutomobileAdInsertRequest, AutomobileAd>();
            CreateMap<AutomobileAdUpdateRequest, AutomobileAd>();

            CreateMap<CarCategory, Model.CarCategory>();
            CreateMap<CarCategoryUpdateRequest,Database.CarCategory>();
            CreateMap<CarCategoryInsertRequest, Database.CarCategory>();


            CreateMap<CarBrand, Model.CarBrand>();
            CreateMap<CarBrandUpdateRequest, Database.CarBrand>();
            CreateMap<CarBrandInsertRequest, Database.CarBrand>();

            CreateMap<AutoTrader.Services.Database.CarModel, AutoTrader.Model.CarModel>();

            CreateMap<AdditionalEquipment, Model.AdditionalEquipment>();
            CreateMap<AdditionalEquipmentInsertRequst, Database.AdditionalEquipment>();


            CreateMap<VehicleCondition, Model.VehicleCondition>();
            CreateMap<VehicleConditionInsertRequst, Database.VehicleCondition>();

            CreateMap<City, Model.City>();
            CreateMap<CityRequest, Database.City>();

            CreateMap<Canton, Model.Canton>();
            CreateMap<CantonRequest, Database.Canton>();


            CreateMap<Comment, Model.Comment>();
            CreateMap<CommentInsertRequest, Database.Comment>();


            CreateMap<Reservation, Model.Reservation>();
            CreateMap<ReservationRequst, Database.Reservation>();

            CreateMap<FuelType, Model.FuelType>();
            CreateMap<FuelTypeRequest, Database.FuelType>();

            CreateMap<TransmissionType, Model.TransmissionType>();
            CreateMap<TransmissionTypeRequst, Database.TransmissionType>();
        }
	}
}



