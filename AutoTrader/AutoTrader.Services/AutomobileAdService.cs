using System;
using AutoTrader.Model;
using AutoTrader.Services.Database;

namespace AutoTrader.Services
{
    public class AutomobileAdService : IAutomobileAdService
    {
        AutoTraderContext _context;

        public AutomobileAdService(AutoTraderContext context)
        {
            _context = context;
        }

        List<AutomobileAd> AutomobileAd = new List<AutomobileAd>() {
            new AutomobileAd()
            {
                Id = 1,
                Title = "Skoda fabija",
                Registered = false
            }
        };

        public IList<AutomobileAd> Get()
        {
            var list = _context.AutomobileAds.ToList();
            return list;
        }
    }
}

