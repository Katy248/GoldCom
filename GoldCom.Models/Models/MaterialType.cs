using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldCom.Domen.Models;
public class MaterialType : DbEntity
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
        return $"{Name} {Price}";
    }
}
