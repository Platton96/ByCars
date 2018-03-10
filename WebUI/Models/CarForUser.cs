using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models
{
    public class CarForUser
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string UrlImg { get; set; }
        public int Year { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
        public bool NewOffer { get; set; }
        public string NameOwner { get; set; }
        public int PhoneNumberOwner { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string District { get; set; }
    }
}