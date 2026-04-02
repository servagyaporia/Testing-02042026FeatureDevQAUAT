
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Linq;
using Retail_Web_DFA.Models;
namespace Retail_Web_DFA.Repository
{
    public class AccountRepository:IAccountRepository
    {
        private readonly AppDbContext _context;

        public AccountRepository(AppDbContext context)
        {
            _context = context;
        }

        public User Login(string username, string password)
        {
            var user = _context.Users
                .FromSqlRaw("EXEC sp_LoginUser @Username, @Password",
                    new SqlParameter("@Username", username),
                    new SqlParameter("@Password", password))
                .AsEnumerable()
                .FirstOrDefault();

            return user;
        }
    }
}
