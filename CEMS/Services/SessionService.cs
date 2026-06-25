namespace CEMS.Services
{
    public class SessionService
    {
        public bool IsAdmin { get; private set; } = false;

        private const string AdminPin = "admin123";

        public bool TryLogin(string pin)
        {
            if (pin == AdminPin)
            {
                IsAdmin = true;
                return true;
            }
            return false;
        }

        public void Logout() => IsAdmin = false;
    }
}