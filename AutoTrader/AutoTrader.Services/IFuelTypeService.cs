using System;
using AutoTrader.Model.Requests;
using AutoTrader.Model.SearchObjects;
namespace AutoTrader.Services
{
	public interface IFuelTypeService :ICRUDService<Model.FuelType,BaseSearchObject,FuelTypeRequest,FuelTypeRequest>
	{
	
	}
}

