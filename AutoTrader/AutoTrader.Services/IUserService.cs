using System;
using AutoTrader.Model.Requests;
using AutoTrader.Model.SearchObjects;

namespace AutoTrader.Services
{
    public interface IUserService : ICRUDService<Model.User, UserSearchObject,UsersInsertRequests,UsersUpdateRequest>
    {
        Model.User Login(string username, string password);
    }

}

