using FitLog.Model;

namespace FitLog.Dto
{
    public record UserDto (long Id ,string Name, int Age, string Email)
    {

        public static UserDto FromEntity(User user)
        {
            return new UserDto(user.Id, user.Name, user.Age, user.Email);
        }

        public static User ToEntity(UserDto userDto) {
            return new User(userDto.Name, userDto.Age, userDto.Email);
        }
    }
}
