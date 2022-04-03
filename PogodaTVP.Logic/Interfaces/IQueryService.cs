namespace PogodaTVP.Logic.Interfaces
{
    public interface IQueryService
    {
        string CreateQueryString<T>(T _object);
    }
}
