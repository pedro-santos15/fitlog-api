using FitLog.Model;

namespace FitLog.Dto
{
    public record UserDto (string Name, int Age, string Email)
    {

        public static UserDto FromEntity(User user)
        {
            return new UserDto(user.Name, user.Age, user.Email);
        }

        public static User ToEntity(UserDto userDto) {
            return new User(userDto.Name, userDto.Age, userDto.Email);
        }
    }
}
