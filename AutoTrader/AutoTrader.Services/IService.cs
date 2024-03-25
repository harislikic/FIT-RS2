using System;
using AutoTrader.Model;
using AutoTrader.Model.Requests;
using Microsoft.AspNetCore.JsonPatch;

namespace AutoTrader.Services
{
    public interface IService<T, Tsearch, TUpdate, TInsert> where Tsearch : class
    {
        Task<PagedResult<T>> Get(Tsearch search = null);

        Task<T> GetById(int id);

        Task<T> DeleteById(int id);

        Task<T> UpdateById(int id, TUpdate request);

        Task<T> Insert(TInsert request);

    }

}

