using System;
using AutoMapper;
using AutoTrader.Model.Requests;
using AutoTrader.Model.SearchObjects;
using AutoTrader.Services.Database;
using AutoTrader.Services.Helpers;
using Microsoft.EntityFrameworkCore;

namespace AutoTrader.Services
{
    public class CarCategoryService : BaseCRUDService<Model.CarCategory, CarCategory, CarCategorySearchObjects, CarCategoryInsertRequest , CarCategoryUpdateRequest>, ICarCategoryService
    {
        public CarCategoryService(AutoTraderContext context, IMapper mapper) : base(context, mapper)
        {

        }


        public override IQueryable<CarCategory> AddFilter(IQueryable<CarCategory> query, CarCategorySearchObjects? search = null)
        {

            if (!string.IsNullOrWhiteSpace(search?.Name))
            {
                query = query.Where(x => x.Name.StartsWith(search.Name));
            }

            if (!string.IsNullOrWhiteSpace(search?.FTS))
            {
                query = query.Where(x => x.Name.Contains(search.FTS));
            }


            return base.AddFilter(query, search);
        }
    }
}

