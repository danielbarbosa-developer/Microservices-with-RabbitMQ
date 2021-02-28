using Application.Abstractions.Interfaces;

namespace Application.Domain.Entities
{
    public class Restaurant : IRestaurant
    {
        public string Name {get; set;}
        public string City {get; set;}
        
    }
}