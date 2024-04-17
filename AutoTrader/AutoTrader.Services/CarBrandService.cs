using System;
using AutoMapper;
using AutoTrader.Model.Requests;
using AutoTrader.Model.SearchObjects;
using AutoTrader.Services.Database;
using AutoTrader.Services.Helpers;

namespace AutoTrader.Services
{
    public class CarBrandService : BaseCRUDService<Model.CarBrand, CarBrand, BaseSearchObject, CarBrandInsertRequest, CarBrandUpdateRequest>, ICarBrandService
    {
        public CarBrandService(AutoTraderContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}




