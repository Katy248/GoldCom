﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldCom.Domain.Models;
public class Customer : DbEntity
{
    public string CompanyName { get; set; }
    public string CompanyAddress { get; set; }
    public string CompanyPhone { get; set; }
    public string CompanyMail { get; set; }
    public string OGRN { get; set; }
    public string INN { get; set; }
    public string OKPO { get; set; }
    public string OKVED { get; set; }
    public string RepresentativeFirstName { get; set; }
    public string RepresentativeSurname { get; set; }
    public string RepresentativeLastName { get; set; }
    public string RepresentativePhone { get; set; }
    public string RepresentativeEmail { get; set; }
    public string CeoFirstName { get; set; }
    public string CeoSurname { get; set; }
    public string CeoLastName { get; set; }
    public string RepresentativeName => $"{RepresentativeSurname} {RepresentativeFirstName} {RepresentativeLastName}";
    public string CeoName => $"{CeoSurname} {CeoFirstName} {CeoLastName}";

    public override string ToString()
    {
        return $"{CompanyName}, {CompanyMail}";
    }
}
