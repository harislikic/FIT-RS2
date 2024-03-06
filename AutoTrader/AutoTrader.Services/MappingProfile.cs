using System;
using AutoMapper;

namespace AutoTrader.Services
{
	public class MappingProfile : Profile
	{
        public MappingProfile()
        {
            CreateMap<Database.User, Model.User>();
            CreateMap<Model.Requests.UsersInsertRequests, Database.User>();
            CreateMap<Model.Requests.UsersUpdateRequest, Database.User>();

            CreateMap<Database.Comment, Model.Comment>();
            CreateMap<Database.CarCategory, Model.CarCategory>();
        }
	}
}

