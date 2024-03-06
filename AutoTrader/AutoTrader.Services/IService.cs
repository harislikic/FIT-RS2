using System;
using AutoTrader.Model;

namespace AutoTrader.Services
{
	public interface IService<T, Tsearch> where Tsearch : class
	{
		Task<PagedResult<T>> Get(Tsearch search = null);

        Task<T> GetById(int id);

        Task<T> DeleteById(int id);

    }
}

