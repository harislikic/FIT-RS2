using System;
using AutoTrader.Model;

namespace AutoTrader.Services.Database
{
	public partial class AdImage
	{
        public int AdImageId { get; set; }

        public int AutomobileAdId { get; set; }

        public string  Name { get; set; }

        public string URL { get; set; }

        public AutomobileAd AutomobileAd { get; set; }
    }

}






