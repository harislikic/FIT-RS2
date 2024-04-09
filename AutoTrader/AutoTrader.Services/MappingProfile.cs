using System;
using AutoMapper;
using AutoTrader.Model.Requests;

namespace AutoTrader.Services
{
	public class MappingProfile : Profile
	{
        public MappingProfile()
        {
            CreateMap<Database.User, Model.User>();
            CreateMap<UsersInsertRequests, Database.User>();
            CreateMap<UsersUpdateRequest, Database.User>();


            CreateMap<AutomobileAd, Model.AutomobileAd>();
            CreateMap<AutomobileAdInsertRequest, AutomobileAd>();
            CreateMap<AutomobileAdUpdateRequest, AutomobileAd>();

            CreateMap<Database.Comment, Model.Comment>();

            CreateMap<Database.CarCategory, Model.CarCategory>();
            CreateMap<CarCategoryUpdateRequest,Database.CarCategory>();
            CreateMap<CarCategoryInsertRequest, Database.CarCategory>();


            CreateMap<Database.CarBrand, Model.CarBrand>();
            CreateMap<CarBrandUpdateRequest, Database.CarBrand>();
            CreateMap<CarBrandInsertRequest, Database.CarBrand>();
        }
	}
}

