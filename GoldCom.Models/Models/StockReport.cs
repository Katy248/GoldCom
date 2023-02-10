using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldCom.Domen.Models;
public abstract class StockReport : DbEntity
{
    public StockUnit StockUnit { get; set; }
    public User Employee { get; set; }
}
