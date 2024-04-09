using System;
using AutoTrader.Model.Requests;
using AutoTrader.Model.SearchObjects;

namespace AutoTrader.Services
{
    public interface ICarBrandService : ICRUDService<Model.CarBrand, BaseSearchObject, CarBrandInsertRequest, CarBrandUpdateRequest>
	{
		
	}

}

