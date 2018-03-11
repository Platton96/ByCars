
using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class BuyingCar
    {
        public int Id { get; set; }
        public Car Car { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public OwnerCar OwnerCar {get; set;}
        public bool NewOffer { get; set; }
        public bool FavoriteOffer { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOffer { get; set; }
    }
}
