using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldCom.Domain.Models;
public class ShipmentReport : StockReport
{
    public DateTime ShipmentDate { get; set; }
}
