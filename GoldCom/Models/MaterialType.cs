using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldCom.Models;
public class MaterialType : DbEntity
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}
