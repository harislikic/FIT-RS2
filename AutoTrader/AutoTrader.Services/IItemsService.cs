using System;
using System.Collections.Generic;
using AutoTrader.Model;

namespace AutoTrader.Services
{
	public interface IItemService
	{

		IList<Item> Get();
    }
}
