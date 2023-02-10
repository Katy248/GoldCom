using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldCom.Domen.Models;
public class User : DbEntity
{
    public string FistName { get; set; }
    public string Surname { get; set; }
    public string LastName { get; set; }
    public Position Position { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}
