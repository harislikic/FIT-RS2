using System;
using AutoMapper;
using AutoTrader.Model;
using AutoTrader.Model.Requests;
using AutoTrader.Model.SearchObjects;
using AutoTrader.Services.Database;

namespace AutoTrader.Services
{
    public class CantonService : BaseCRUDService<Model.Canton, Database.Canton, BaseSearchObject, CantonRequest,CantonRequest>, ICantonService
    {
        public CantonService(AutoTraderContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}

