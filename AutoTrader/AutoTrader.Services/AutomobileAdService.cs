using System;
using AutoMapper;
using AutoTrader.Model;
using AutoTrader.Model.Requests;
using AutoTrader.Model.SearchObjects;
using AutoTrader.Services.Database;

namespace AutoTrader.Services
{
    public class AutomobileAdService : BaseCRUDService<Model.AutomobileAd, AutomobileAd, AutomobileAdSearchObject, AutomobileAdInsertRequest, AutomobileAdUpdateRequest>, IAutomobileAdService
    {


        public AutomobileAdService(AutoTraderContext context, IMapper mapper) : base(context, mapper)
        {

        }


        public override IQueryable<AutomobileAd> AddFilter(IQueryable<AutomobileAd> query, AutomobileAdSearchObject? search = null)
        {
            if (!string.IsNullOrWhiteSpace(search?.Title))
            {
                query = query.Where(x => x.Title.Contains(search.Title));
            }

            if (search?.PriceFrom != null && search?.PriceTo != null)
            {
                query = query.Where(x => x.Price >= search.PriceFrom && x.Price <= search.PriceTo);
            }

            if (search?.PriceFrom != null)
            {
                query = query.Where(x => x.Price >= search.PriceFrom);
            }

            if (search?.PriceTo != null)
            {
                query = query.Where(x => x.Price <= search.PriceTo);
            }

            if (search?.IsActive != null)
            {
                query = query.Where(x => x.IsActive == search.IsActive);
            }

            if (search?.IsApproved != null)
            {
                query = query.Where(x => x.IsApproved == search.IsApproved);
            }

            return base.AddFilter(query, search);
        }

    }
}

