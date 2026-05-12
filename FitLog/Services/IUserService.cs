using FitLog.Dto;

namespace FitLog.Services
{
    public interface IUserService
    {
        Task<UserDto> GetUserByIdAsync(long id);
        Task<List<UserDto>> GetAllUsersAsync();
        Task<UserDto> CreateUserAsync(UserDto user);
        Task<UserDto> UpdateUserAsync(long id, UserDto user);
        Task DeleteUser(long id);

        
    }
}
