namespace Fuxion.Ali.Contracts.Users.List
{
    public class UserFilters
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string[] Roles { get; set; } = [];
        public string? Email { get; set; }
        public string? Phone { get; set; }
    }
}
