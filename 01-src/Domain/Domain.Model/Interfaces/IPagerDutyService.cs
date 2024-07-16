using Domain.Models;

namespace Domain.Interfaces
{
    public interface IPagerDutyService
    {
        Task<UserResponse> GetUserAsync(int limit,int offset);
        Task<List<ContactMethod>> GetUserContact(string id);

    }
}