using System;
namespace AutoTrader.Services.Database
{
    public partial class City
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CantonId { get; set; }
        public Canton Canton { get; set; }
    }
}



