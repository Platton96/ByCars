using WebUI.Models;
using System.Collections.Generic;
using System.Linq;
using Domain.Entity;


namespace WebUI.DbProvider
{
    public class DbProvider
    {
        private string userId=null;
        public DbProvider(string id)
        {
            userId = id;
        }
        private static IEnumerable<CarForUser> ConvertCarAndOwnerToCarForUser(IQueryable<BuyingCar> buyingCars)
        {
            return buyingCars
                 .Select(offer => new CarForUser
                 {
                     Model = offer.Car.Model,
                     Brand = offer.Car.Brand,
                     Cost = offer.Car.Cost,
                     Year = offer.Car.Year,
                     UrlImg = offer.Car.UrlImg,
                     Description = offer.Car.Description,
                     NameOwner = offer.OwnerCar.Name,
                     PhoneNumberOwner = offer.OwnerCar.PhoneNumber,
                     Country = offer.OwnerCar.Country,
                     District = offer.OwnerCar.District,
                     Region = offer.OwnerCar.Region,
                     NewOffer = offer.NewOffer,
                     DateOffer = offer.DateOffer,
                     FavoriteOffer = offer.FavoriteOffer
                     

                 });
        }
        public IEnumerable<SearchQuery> GetAllSearchQueryUser(IQueryable<SearchQuery> queries)
        {
            return queries
                .Where(q => q.ApplicationUser.Id == userId);
        }
        public IEnumerable<CarForUser> GetAllCarForUser(IQueryable<BuyingCar> buyingCars)
        {
            return ConvertCarAndOwnerToCarForUser( buyingCars
                                                   .Where(buyingCar => buyingCar.ApplicationUser.Id == userId)
                                                  )    
                 .OrderByDescending(offer=>offer.NewOffer)
                 .ThenByDescending(offer=>offer.DateOffer);
        }
        public IEnumerable<CarForUser> GetNewCar(IQueryable<BuyingCar> buyingCars)
        {
            return ConvertCarAndOwnerToCarForUser(buyingCars
                                                  .Where(offer => offer.ApplicationUser.Id == userId
                                                              && offer.NewOffer == true
                                                        )
                                                  )
                    .OrderByDescending(offer => offer.DateOffer);
        }
        public IEnumerable<CarForUser> GeFavoriteCar(IQueryable<BuyingCar> buyingCars)
        {
            return ConvertCarAndOwnerToCarForUser(buyingCars
                                                  .Where(offer => offer.ApplicationUser.Id == userId
                                                              && offer.FavoriteOffer == true
                                                        )
                                                  )
                    .OrderByDescending(offer => offer.DateOffer);
        }


    }
}