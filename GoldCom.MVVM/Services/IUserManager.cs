namespace GoldCom.Services;
public interface IUserManager<TUser>
{
    TUser? Login(string login, string password);
    void Logout();
    TUser? User { get; }
}
