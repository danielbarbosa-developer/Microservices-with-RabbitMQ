using System.Collections.Generic;
using Application.Abstractions.Interfaces;
using Application.Domain.Entities;

namespace Application.Domain.Repositories
{
    public class DeliveryQueriesRepository : IDeliveryQueriesRepository
    {
        public IEnumerable<IFood> GetAllFoods(string restaurant)
        {
            yield return new Food("Pizza", 50.00);
        }

        public IEnumerable<IRestaurant> GetAllRestaurants(string city)
        {
            yield return new Restaurant
            {
                Name = "Pizza na Brasa",
                City = "Florianopolis, Brazil"
            };
        }
    }
}