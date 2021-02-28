using System.Collections.Generic;

namespace Application.Abstractions.Interfaces
{
    public interface IDeliveryQueriesRepository
    {
        IEnumerable<IRestaurant> GetAllRestaurants(string city); 
        IEnumerable<IFood> GetAllFoods(string restaurant);
    }
}