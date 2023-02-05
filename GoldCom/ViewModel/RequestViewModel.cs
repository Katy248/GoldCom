using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using GoldCom.Database;
using GoldCom.Models;
using KVVM.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace GoldCom.ViewModel;

public class RequestViewModel : ViewModelBase
{
    public RequestViewModel(User employee)
    {
        Request = new();
        RequestStockUnit = new();
        Employee = employee;
        using (var context = new ApplicationDbContext(null)) //TODO: finish
        {
            foreach (var type in context.MaterialTypes.ToArray())
            {
                MaterialTypes.Add(new Label() { Content = type });
            }
            foreach (var customer in context.Customers.ToArray())
            {
                Customers.Add(new Label() { Content = customer });
            }
            SelectedMaterialType = MaterialTypes.FirstOrDefault();
            SelectedCustomersLabel = Customers.FirstOrDefault();
        }
    }
    private readonly StockUnit RequestStockUnit;
    private readonly Request Request;
    private readonly User Employee;
    public string AuthenticityCertificateNumber
    {
        get => RequestStockUnit.AuthenticityCertificateNumber.ToString();
        set
        {
            if (int.TryParse(value, out int result))
            {
                RequestStockUnit.AuthenticityCertificateNumber = result;
            }
        }
    }
    public string AdditionalElementsPercentage
    {
        get => RequestStockUnit.AdditionalElementsPercentage.ToString() + " %";
        set
        {
            if (int.TryParse(value.Replace("%",""), out int result))
            {
                if (result < 0) result = 0;
                if (result > 97) result = 97;
                RequestStockUnit.AdditionalElementsPercentage = result;
            }
        }
    }
    public List<Label> MaterialTypes = new();
    public List<Label> Customers = new();
    private Label? selectedMaterialType;
    private Label? selectedCustomersLabel;

    public Label? SelectedMaterialType
    {
        get => selectedMaterialType ?? MaterialTypes.FirstOrDefault();
        set
        {
            selectedMaterialType = value;
            RequestStockUnit.MaterialType = value?.Content as MaterialType;
        }
    }
    public Label? SelectedCustomersLabel
    {
        get => selectedCustomersLabel ?? Customers.FirstOrDefault();
        set
        {
            selectedCustomersLabel = value;
            Request.Customer = value?.Content as Customer;
        }
    }

    public bool Validate()
    {
        return 
            Request.Customer is null 
            || RequestStockUnit.MaterialType is null 
            || RequestStockUnit.AuthenticityCertificateNumber == 0 
            || RequestStockUnit.AdditionalElementsPercentage <= 0;
    }
    public void UpdateData()
    {
        if (Validate()) return;
        
        Request.CreationDate = DateTime.Now;
        using (var context = new ApplicationDbContext(null))//TODO: finish
        {
            Request.Employee = context.Users.First(u=> u.Id == Employee.Id);
            Request.Customer = context.Customers.First(c => c.Id == (SelectedCustomersLabel.Content as Customer).Id);
            RequestStockUnit.MaterialType = context.MaterialTypes.First(m => m.Id == (selectedMaterialType.Content as MaterialType).Id);
            context.Add(Request);
            context.Add(RequestStockUnit);
            RequestStockUnit.Request = Request;
            context.SaveChanges();
        }

    }
}
