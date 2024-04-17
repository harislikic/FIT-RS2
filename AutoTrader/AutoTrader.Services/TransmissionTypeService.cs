using System;
using AutoMapper;
using AutoTrader.Model.Requests;
using AutoTrader.Model.SearchObjects;
using AutoTrader.Services.Database;
namespace AutoTrader.Services
{
    public class TransmissionTypeService : BaseCRUDService<Model.TransmissionType, Database.TransmissionType, BaseSearchObject, TransmissionTypeRequst, TransmissionTypeRequst>, ITransmissionTypeService
    {
        public TransmissionTypeService(AutoTraderContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}

