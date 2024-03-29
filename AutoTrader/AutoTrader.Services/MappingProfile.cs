﻿using System;
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

            CreateMap<Database.Comment, Model.Comment>();

            CreateMap<Database.CarCategory, Model.CarCategory>();
            CreateMap<CarCategoryUpdateRequest,Database.CarCategory>();
            CreateMap<CarCategoryInsertRequest, Database.CarCategory>();
        }
	}
}

