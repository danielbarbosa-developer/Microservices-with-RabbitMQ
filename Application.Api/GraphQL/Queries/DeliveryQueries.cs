using System.Collections.Generic;
using Application.Abstractions.Interfaces;
using HotChocolate;
using HotChocolate.Types;

namespace Application.Api.GraphQL.Queries
{
    
    public class DeliveryQueries
    {
        public IEnumerable<IRestaurant> GetRestaurants(
            string city,
            [Service] IDeliveryQueriesRepository repository) =>
            repository.GetAllRestaurants(city);
        
        public IEnumerable<IFood> GetFoods(
            string restaurant,
            [Service] IDeliveryQueriesRepository repository) =>
            repository.GetAllFoods(restaurant);
    }
}