using System;
using AutoMapper;
using AutoTrader.Model;
using AutoTrader.Model.Requests;
using AutoTrader.Model.SearchObjects;

namespace AutoTrader.Services
{
    public class VehicleConditionService : BaseCRUDService<VehicleCondition, Database.VehicleCondition, BaseSearchObject, VehicleConditionInsertRequst, VehicleConditionInsertRequst>, IVehicleConditionService
    {
        public VehicleConditionService(Database.AutoTraderContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}

