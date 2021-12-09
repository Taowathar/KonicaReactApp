using KonicaReactApp.Models;

namespace KonicaReactApp.Services
{
    public interface ILoginRepository
    {
        void AddLogin(Login login);
        int GetFailedLogins(string userName);
        bool GetAccountDisabled(string userName);
    }
}
