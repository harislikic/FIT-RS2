using System;
using AutoTrader.Model;

namespace AutoTrader.Services.Database
{
	public partial class Reservation
	{
        public int Id { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }


        public int? UserId { get; set; }
        public User User { get; set; }


        public int? AutomobileAdId { get; set; }
        public AutomobileAd AutomobileAd { get; set; }

    }
}

