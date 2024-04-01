using System;
namespace AutoTrader.Services
{
	public interface ICRUDService<T, TSearch, TInsert, TUpdate> : IService<T, TSearch> where TSearch : class
    {
        Task<T> Insert(TInsert request);

        Task<T> Update(int id, TUpdate request);

        Task<T> Delete(int id);
    }
}




