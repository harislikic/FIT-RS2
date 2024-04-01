using System;
using AutoTrader.Model;
using AutoTrader.Model.Requests;
using Microsoft.AspNetCore.JsonPatch;

namespace AutoTrader.Services
{
    public interface IService<T, Tsearch> where Tsearch : class
    {
        Task<PagedResult<T>> Get(Tsearch? search = null);

        Task<T> GetById(int id);
    }
}


