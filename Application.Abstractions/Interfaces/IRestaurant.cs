namespace Application.Abstractions.Interfaces
{
    public interface IRestaurant : ISearchResult
    {
        string Name {get; set;}
        string City {get; set;}
    }
}