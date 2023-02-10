using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldCom.Domen.Models;
public class StockUnit : DbEntity
{
    public MaterialType MaterialType { get; set; }
    public Request Request { get; set; }
    public int AuthenticityCertificateNumber { get; set; }
    public int AdditionalElementsPercentage { get; set; }
}
