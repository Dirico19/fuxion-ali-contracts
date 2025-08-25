namespace Fuxion.Ali.Contracts.Common.Dtos
{
    public class UserDto
    {
        public Guid? UserId { get; set; }
        public string? UserName { get; set; }
        public Guid? RoleId { get; set; }
        public string? Role { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

        public UserDto() { }

        public UserDto(
            Guid? userId,
            string? userName, 
            Guid? roleId,
            string? role,
            string? firstName, 
            string? lastName, 
            string? email, 
            string? phone)
        {
            UserId = userId;
            UserName = userName;
            RoleId = roleId;
            Role = role;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
        }
    }
}
