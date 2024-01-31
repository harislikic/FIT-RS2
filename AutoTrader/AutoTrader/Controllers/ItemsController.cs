using AutoTrader.Model;
using AutoTrader.Services;
using Microsoft.AspNetCore.Mvc;

namespace AutoTrader.Controllers;

[ApiController]
[Route("[controller]")]
public class ItemsController : ControllerBase
{
    private readonly IItemService _itemServices;
    private readonly ILogger<WeatherForecastController> _logger;

    public ItemsController(ILogger<WeatherForecastController> logger, IItemService itemService)
    {
        _logger = logger;
        _itemServices = itemService;
    }

    [HttpGet]
    public IEnumerable<Item> Get()
    {
        return _itemServices.Get();
    }
}

