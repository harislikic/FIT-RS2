using System;
using AutoMapper;
using AutoTrader.Model;
using AutoTrader.Model.Requests;
using AutoTrader.Model.SearchObjects;
namespace AutoTrader.Services
{
    public class CityService : BaseCRUDService<City, Database.City, BaseSearchObject, CityRequest, CityRequest>, ICityService
    {
        public CityService(Database.AutoTraderContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}

