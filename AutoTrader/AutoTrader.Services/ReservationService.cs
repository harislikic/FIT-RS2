using System;
using AutoMapper;
using AutoTrader.Model.Requests;
using AutoTrader.Model.SearchObjects;
using AutoTrader.Services.Database;
namespace AutoTrader.Services
{
    public class ReservationService : BaseCRUDService<Model.Reservation, Database.Reservation, BaseSearchObject, ReservationRequst, ReservationRequst>, IReservationService
    {
        public ReservationService(AutoTraderContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}

