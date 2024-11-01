namespace User_Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccountService accountService = new AccountService();

            User user = new("Huseyn", "Abbasov", "nI34G87g6Er", "nI34G87g6Er");

            accountService.Register(user);
            accountService.Login(user.Name, user.Password);
            accountService.Logout();
        }
    }
}
