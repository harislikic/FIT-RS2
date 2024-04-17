using System;
using AutoMapper;
using AutoTrader.Model.Requests;
using AutoTrader.Model.SearchObjects;
using AutoTrader.Services.Database;
namespace AutoTrader.Services
{
    public class FuelTypeService : BaseCRUDService<Model.FuelType, FuelType, BaseSearchObject, FuelTypeRequest, FuelTypeRequest>, IFuelTypeService
    {
        public FuelTypeService(AutoTraderContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}

