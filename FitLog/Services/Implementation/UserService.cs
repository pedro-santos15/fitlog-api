using FitLog.Dto;
using FitLog.Exceptions;
using FitLog.Model;
using FitLog.Repositories;

namespace FitLog.Services.Implementation
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserDto> CreateUserAsync(UserDto user)
        {
            var userEntity = UserDto.ToEntity(user);

            if (userEntity != null)
            {
                await _userRepository.CreateAsync(userEntity);
                return UserDto.FromEntity(userEntity);
            }

            throw new InvalidOperationException("Failed to create user.");

        }

        public async Task DeleteUser(long id)
        {
            var user = await _userRepository.FindByIdAsync(id);

            if (user != null)
            {
                await _userRepository.DeleteAsync(id);
            }
            else
            {
                throw new UserNotFoundException("User not found.");
            }
        }

        public async Task<List<UserDto>> GetAllUsersAsync()
        {
            var users = await _userRepository.FindAllAsync();

            return users.Select(UserDto.FromEntity).ToList();
        }

        public async Task<UserDto> GetUserByIdAsync(long id)
        {
            var user = await _userRepository.FindByIdAsync(id);

            if (user != null)
            {
                return UserDto.FromEntity(user);
            }
            else
            {
                throw new UserNotFoundException("User not found.");
            }
        }

        public async Task<UserDto> UpdateUserAsync(long id, UserDto user)
        {
            var userFound =  await _userRepository.FindByIdAsync(id);

            if (userFound != null)
            {
                var userEntity = UserDto.ToEntity(user);
                userEntity.Id = id;

                await _userRepository.UpdateAsync(userEntity);

                return UserDto.FromEntity(userEntity);
            }

            throw new UserNotFoundException("User not found.");
        }
    }
}
