using System;
using AutoTrader.Model;

namespace AutoTrader.Services.Database
{
	public partial class MaintenanceServie
	{
		public int MaintenanceServieId { get; set; }

		public DateTime Last_Small_Service { get; set; }

		public DateTime Last_Big_Service { get; set; }

		public string Milage { get; set; }

    }
}

