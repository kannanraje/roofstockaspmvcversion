using roofstock.Core.Models;
using roofstock.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roofstock.Core.Repository
{
    public interface IPropertyRepository
    {
        IEnumerable<PropertyViewModel> GetAll();
        PropertyViewModel GetById(int EmployeeID);
        void Insert(AddPropertyModel employee);
        void Save();
    }
}
