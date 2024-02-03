using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoTrader.Model;

namespace AutoTrader.Services.Database
{
	public partial class Comment
	{
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }

 
        public int? UserId { get; set; }
        public User User { get; set; }

      
        public int? AutomobileAdId { get; set; }
        public AutomobileAd AutomobileAd { get; set; }
    }
}

