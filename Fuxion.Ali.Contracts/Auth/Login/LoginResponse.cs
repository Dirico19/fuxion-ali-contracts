namespace Fuxion.Ali.Contracts.Auth.Login
{
    public class LoginResponse
    {
        public string Token { get; set; } = string.Empty;

        public LoginResponse(string token)
        {
            Token = token;
        }
    }
}
