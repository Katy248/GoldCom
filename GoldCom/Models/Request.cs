using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldCom.Models;
public class Request : DbEntity
{
    public User Customer { get; set; }
    public User Employee { get; set; }
    public DateTime CreationDate { get; set; }
}
