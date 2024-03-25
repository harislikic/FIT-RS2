using System;
using AutoTrader.Model.Requests;
using AutoTrader.Model.SearchObjects;

namespace AutoTrader.Services
{
    public interface IUserService : IService<Model.User, UserSearchObject, UsersUpdateRequest, UsersInsertRequests>
    {
        Model.User Login(string username, string password);
    }
}

