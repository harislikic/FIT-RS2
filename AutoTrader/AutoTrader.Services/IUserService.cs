using System;
using AutoTrader.Model.Requests;
using AutoTrader.Model.SearchObjects;

namespace AutoTrader.Services
{
	public interface IUserService : IService<Model.User,UserSearchObject>
	{
		//Task<List<Model.User>> Get();

		//Model.User Insert(UsersInsertRequests request);

  //      Model.User Update(int id, UsersUpdateRequest request);

  //      Model.User Delete(int id);
    } 
}

