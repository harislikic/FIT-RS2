using System;
using AutoMapper;
using AutoTrader.Model;
using AutoTrader.Model.SearchObjects;
using AutoTrader.Services.Database;
using Microsoft.EntityFrameworkCore;

namespace AutoTrader.Services
{
    public class BaseService<T, TDb, TSearch> : IService<T, TSearch> where TDb : class where T : class where TSearch : BaseSearchObject
    {

       protected AutoTraderContext _context;

        public IMapper _mapper { get; set; }

        public BaseService(AutoTraderContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual async Task<PagedResult<T>> Get(TSearch? search = null)
        {
            var query = _context.Set<TDb>().AsQueryable();

            PagedResult<T> result = new PagedResult<T>();

            query = AddFilter(query, search);

            result.TotalElements = await query.CountAsync();

            if (search?.Page.HasValue == true && search?.PageSize.HasValue == true)
            {
                query = query.Take(search.PageSize.Value).Skip(search.Page.Value * search.PageSize.Value);
            }

            var list = await query.ToListAsync();

            var tmp = _mapper.Map<List<T>>(list);
            result.Result = tmp;
            return result;
        }

        public virtual IQueryable<TDb> AddFilter(IQueryable<TDb> query, TSearch? search = null)
        {
            return query;
        }

        public virtual async Task<T> GetById(int id)
        {
            var entity = await _context.Set<TDb>().FindAsync(id);

            return _mapper.Map<T>(entity);
        }

        public virtual async Task<T> DeleteById(int id)
        {
            var entity = await _context.Set<TDb>().FindAsync(id);
            if (entity == null)
            {
                return null;
            }

            _context.Set<TDb>().Remove(entity);
            await _context.SaveChangesAsync();

            return _mapper.Map<T>(entity);
        }

}
}