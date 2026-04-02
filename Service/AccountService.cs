using Retail_Web_DFA.Models;
using Retail_Web_DFA.Repository;

namespace Retail_Web_DFA.Service
{
    public class AccountService
    {
        private readonly IAccountRepository _repository;

        public AccountService(IAccountRepository repository)
        {
            _repository = repository;
        }

        public User Login(string username, string password)
        {
            return _repository.Login(username, password);
        }
    }
}
