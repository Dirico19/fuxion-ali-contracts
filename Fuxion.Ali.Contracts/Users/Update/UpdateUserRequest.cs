namespace Fuxion.Ali.Contracts.Users.Update
{
    public class UpdateUserRequest
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public Guid RoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public UpdateUserRequest() { }
        public UpdateUserRequest(
            Guid userId, 
            string userName, 
            Guid roleId,
            string firstName, 
            string lastName, 
            string email, 
            string phone)
        {
            UserId = userId;
            UserName = userName;
            RoleId = roleId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
        }
    }
}
