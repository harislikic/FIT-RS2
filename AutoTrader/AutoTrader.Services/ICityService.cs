using System;
using AutoTrader.Model;
using AutoTrader.Model.Requests;
using AutoTrader.Model.SearchObjects;

namespace AutoTrader.Services
{
	public interface ICityService : ICRUDService<City,BaseSearchObject,CityRequest,CityRequest>
	{
		
	}
}

