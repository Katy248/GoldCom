using System.Linq;
using GoldCom.Database;
using GoldCom.Domen.Interfaces;
using GoldCom.Domen.Models;

namespace GoldCom.Services;
public class UserManager : IUserManager<User>
{
    private readonly IApplicationDbContext context;

    public UserManager(ApplicationDbContext context)
    {
        this.context = context;
    }

    public User? User { get; set; }

    public User? Login(string login, string password)
    {
        return User = context.Users
                .FirstOrDefault(u => u.Email == login && u.Password == password);
    }

    public void Logout()
    {
        this.User = null;
    }
}
