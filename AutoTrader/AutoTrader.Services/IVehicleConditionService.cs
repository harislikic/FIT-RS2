using System;
using AutoTrader.Model;
using AutoTrader.Model.Requests;
using AutoTrader.Model.SearchObjects;

namespace AutoTrader.Services
{
	public interface IVehicleConditionService : ICRUDService<VehicleCondition,BaseSearchObject,VehicleConditionInsertRequst, VehicleConditionInsertRequst>
	{
		
	}
}

