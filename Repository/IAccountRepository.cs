using Retail_Web_DFA.Models;

namespace Retail_Web_DFA.Repository
{
    public interface IAccountRepository
    {
        User Login(string username, string password);
    }
}
