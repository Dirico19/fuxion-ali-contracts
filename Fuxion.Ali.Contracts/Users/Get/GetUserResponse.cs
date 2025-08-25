using Fuxion.Ali.Contracts.Common.Dtos;

namespace Fuxion.Ali.Contracts.Users.Get
{
    public class GetUserResponse
    {
        public UserDto? User { get; set; }

        public GetUserResponse() { }

        public GetUserResponse(UserDto? user)
        {
            User = user;
        }
    }
}
