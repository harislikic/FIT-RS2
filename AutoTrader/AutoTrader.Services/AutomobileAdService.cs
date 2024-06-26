﻿using System;
using AutoMapper;
using AutoTrader.Model;
using AutoTrader.Model.Requests;
using AutoTrader.Model.SearchObjects;
using AutoTrader.Services.Database;
using AutoTrader.Services.Helpers;
using Microsoft.EntityFrameworkCore;

namespace AutoTrader.Services
{
    public class AutomobileAdService : BaseCRUDService<Model.AutomobileAd, AutomobileAd, AutomobileAdSearchObject, AutomobileAdInsertRequest, AutomobileAdUpdateRequest>, IAutomobileAdService
    {


        public AutomobileAdService(AutoTraderContext context, IMapper mapper) : base(context, mapper)
        {

        }


        public override IQueryable<AutomobileAd> AddFilter(IQueryable<AutomobileAd> query, AutomobileAdSearchObject? search = null)
        {
            return base.AddFilter(query, search)
      .Where(x =>
          (string.IsNullOrWhiteSpace(search.Title) || x.Title.Contains(search.Title)) &&
          (search.PriceFrom == null || x.Price >= search.PriceFrom) &&
          (search.PriceTo == null || x.Price <= search.PriceTo) &&
          (search.IsActive == null || x.IsActive == search.IsActive) &&
          (search.IsApproved == null || x.IsApproved == search.IsApproved));
        }

        public override IQueryable<AutomobileAd> AddInclude(IQueryable<AutomobileAd> query, AutomobileAdSearchObject serach = null)
        {

            var filtered = query
                .Include(c => c.TransmissionType)
                .Include(c => c.TransmissionType)
                .Include(x => x.VehicleCondition)
                .Include(x => x.CarBrand)
                .Include(x => x.CarModel)
                .Include(x => x.CarCategory)
                .Include(x => x.User);
            return filtered;
        }

    }
}

