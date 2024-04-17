using System;
using AutoTrader.Model.Requests;
using AutoTrader.Model.SearchObjects;

namespace AutoTrader.Services
{
	public interface IReservationService : ICRUDService<Model.Reservation, BaseSearchObject,ReservationRequst,ReservationRequst>
	{
		
	}
}

