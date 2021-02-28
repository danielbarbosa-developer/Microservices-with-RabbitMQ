namespace Application.Abstractions.Interfaces
{
    public interface IFood : ISearchResult
    {
        string Name{get; set;}
        double Price {get; set;}
    }
}