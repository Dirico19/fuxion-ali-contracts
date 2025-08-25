using Fuxion.Ali.Contracts.Common.Dtos;

namespace Fuxion.Ali.Contracts.Users.List
{
    public class ListUsersResponse
    {
        public List<UserDto> Users { get; set; } = [];

        public ListUsersResponse() { }

        public ListUsersResponse(List<UserDto> users)
        {
            Users = users;
        }
    }
}
