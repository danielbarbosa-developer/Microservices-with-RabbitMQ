using Application.Abstractions.Interfaces;

namespace Application.Domain.Entities
{
    public class Restaurant : IRestaurant
    {
        public Restaurant(string name, string city)
        {
            this.Name = name;
            this.City = city;

        }
        public string Name { get; set; }
        public string City { get; set; }

    }
}