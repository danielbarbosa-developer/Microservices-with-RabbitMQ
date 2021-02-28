using Application.Abstractions.Interfaces;

namespace Application.Domain.Entities
{
    public class Food : IFood
    {

        public Food(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}