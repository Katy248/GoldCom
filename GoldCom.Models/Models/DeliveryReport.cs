﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldCom.Domain.Models;
public class DeliveryReport : StockReport
{
    public DateTime DeliveryDate { get; set; }
}
