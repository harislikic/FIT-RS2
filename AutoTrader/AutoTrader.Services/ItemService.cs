using System;
using AutoTrader.Model;

namespace AutoTrader.Services
{
    public class ItemService : IItemService
    {

        List<Item> items = new List<Item>() {
            new Item()
            {
                ItemId = 1,
                Title = "Skoda fabija"
            }
        };

        public IList<Item> Get()
        {
            return items;
        }
    }
}

