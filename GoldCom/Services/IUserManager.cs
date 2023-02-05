using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoldCom.Database;

namespace GoldCom.Services;
public interface IUserManager<TUser>
{
    TUser? Login(string login, string password, ApplicationDbContext context);
    void Logout();
    TUser? User { get; }
}
