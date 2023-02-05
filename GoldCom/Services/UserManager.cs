using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using GoldCom.Database;
using GoldCom.Models;

namespace GoldCom.Services;
public class UserManager : IUserManager<User>
{
    public User? User { get; set; }

    public User? Login(string login, string password, ApplicationDbContext context)
    {
        return User = context.Users
                .FirstOrDefault(u => u.Email == login && u.Password == password);
    }

    public void Logout()
    {
        this.User = null;
    }
}
