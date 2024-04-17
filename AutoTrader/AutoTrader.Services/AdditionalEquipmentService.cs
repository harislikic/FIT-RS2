using System;
using AutoMapper;
using AutoTrader.Model.Requests;
using AutoTrader.Model.SearchObjects;
using AutoTrader.Services.Database;
using AutoTrader.Services.Helpers;

namespace AutoTrader.Services
{
    public class AdditionalEquipmentService : BaseCRUDService<Model.AdditionalEquipment, AdditionalEquipment, BaseSearchObject,AdditionalEquipmentInsertRequst, AdditionalEquipmentInsertRequst>, IAdditionalEquipmentService
    {
        public AdditionalEquipmentService(AutoTraderContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}

