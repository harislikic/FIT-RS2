﻿using System;
using System.Security.Cryptography;
using System.Text;
using AutoMapper;
using AutoTrader.Model.Requests;
using AutoTrader.Model.SearchObjects;
using AutoTrader.Services.Database;
using AutoTrader.Services.Helpers;
using Microsoft.EntityFrameworkCore;

namespace AutoTrader.Services.Migrations
{
    public class UserService : BaseService<Model.User, User, UserSearchObject, UsersUpdateRequest, UsersInsertRequests>, IUserService
    {


        public UserService(AutoTraderContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public Model.User Login(string username, string password)
        {

            var entity = _context.Users.Where(x => x.UserName == username).FirstOrDefault();
            if (entity == null)
            {
                return null;
            }

            var hash = PasswordHelper.GenerateHash(entity.PasswordSalt, password);

            if (hash != entity.PasswordHash)
            {
                return null;
            }

            return _mapper.Map<Model.User>(entity);

        }


        public override IQueryable<User> AddFilter(IQueryable<User> query, UserSearchObject? search = null)
        {

            if (!string.IsNullOrWhiteSpace(search?.FirstName))
            {
                query = query.Where(x => x.FirstName.StartsWith(search.FirstName));
            }

            if (!string.IsNullOrWhiteSpace(search?.FTS))
            {
                query = query.Where(x => x.UserName.Contains(search.FTS));
            }


            return base.AddFilter(query, search);
        }


    }
}