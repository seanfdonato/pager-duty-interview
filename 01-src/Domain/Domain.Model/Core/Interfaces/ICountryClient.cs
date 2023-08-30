using Domain.Models;

namespace Domain.Core.Interfaces
{
    public interface ICountryClient
    {
        Task<List<Country>> Get(string name);
    }
}