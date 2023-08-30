using Domain.Models;

namespace Domain.Interfaces
{
    public interface ICountryService
    {
        Task<List<Country>> Get(string name);
    }
}