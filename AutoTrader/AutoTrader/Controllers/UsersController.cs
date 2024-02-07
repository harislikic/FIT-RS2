using System;
using AutoTrader.Model;
using AutoTrader.Model.Requests;
using AutoTrader.Services;
using AutoTrader.Services.Database;
using Microsoft.AspNetCore.Mvc;

namespace AutoTrader.Controllers;
[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _service;

    public UserController(IUserService service)
    {
        _service = service;
    }

    [HttpGet]
    public IEnumerable<Model.User> Get()
    {
        return _service.Get();
    }

    [HttpPost]
    public Model.User Insert(UsersInsertRequests request)
    {
        return _service.Insert(request);
    }

    [HttpPut("{id}")]
    public Model.User Update(int id,UsersUpdateRequest request)
    {
        return _service.Update(id, request);
    }
}