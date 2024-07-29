namespace StockAPI.Dtos.Account
{
    public class NewUserDto
    {
        // we can use the accound dto but this is a better practice
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
