using System;
namespace AutoTrader.Services.Database
{
	public  partial class Canton
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public List<City> Cities { get; set; }
    }
}






