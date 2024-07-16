using Domain.Models;

namespace Domain.Core.Interfaces
{
    public interface IPagerDutyClient
    {
        Task<UserResponse> GetUserAsync(int limit,int offset);
        Task<List<ContactMethod>> GetUserContact(string id);
    }
}