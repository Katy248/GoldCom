using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldCom.Domen.Models;
public class Request : DbEntity
{
    public Customer Customer { get; set; }
    public User Employee { get; set; }
    public DateTime CreationDate { get; set; }
}
