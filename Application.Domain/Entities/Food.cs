using Application.Abstractions.Interfaces;

namespace Application.Domain.Entities
{
    public class Food : IFood
    {

        public Food(string name, string price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name { get; set; }
        public string Price { get; set; }
    }
}