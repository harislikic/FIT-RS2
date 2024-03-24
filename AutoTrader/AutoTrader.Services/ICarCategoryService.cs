using System;
using AutoTrader.Model.Requests;
using AutoTrader.Model.SearchObjects;

namespace AutoTrader.Services
{
	public interface  ICarCategoryService : IService<Model.CarCategory, CarCategorySearchObjects, CarCategoryUpdateRequest, CarCategoryInsertRequest>
	{

    }
}

 