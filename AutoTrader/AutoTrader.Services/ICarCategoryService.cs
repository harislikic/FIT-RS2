using System;
using AutoTrader.Model.Requests;
using AutoTrader.Model.SearchObjects;

namespace AutoTrader.Services
{
	public interface  ICarCategoryService : ICRUDService<Model.CarCategory, CarCategorySearchObjects, CarCategoryInsertRequest ,CarCategoryUpdateRequest>
	{

    }
}





