using roofstock.Core.Models;
using roofstock.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roofstock.Core.Repository
{
    public class PropertyRepository:IPropertyRepository
    {
        private readonly PropertyEntities _context;
        
        public PropertyRepository()
        {
            _context = new PropertyEntities();
        }
        public PropertyRepository(PropertyEntities context)
        {
            _context = context;
        }
       
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IEnumerable<PropertyViewModel> GetAll()
        {
            var res = _context.Properties.Join(_context.Addresses, p => p.PropertyId, a => a.PropertyId, (p, a) => new { p, a }).Select(m => m);
            
            return res.ToList().Select(m=>new PropertyViewModel
            {
                Id = m.p.PropertyId,
                AccountId = m.p.AccountId,
                MainImageUrl = m.p.MainImageUrl,
                Yearbuilt = m.p.Yearbuilt,
                MonthlyRent = m.p.MonthlyRent,
                ListPrice = m.p.ListPrice,
                GrossYield = m.p.GrossYield,
                Address=this.FormatAddress(m.a)

            });
          // return res.ToList();
        }

        public string FormatAddress(Address address)
        {
            string formattedAddress = string.Empty;
            //console.log(address);
            if (address != null)
            {
                formattedAddress =
                  address.Address1 != null || address.Address1 != ""
                    ? address.Address1
                    : "";
                formattedAddress =
                  address.Address2 != null || address.Address2 != ""
                    ? formattedAddress + " " + address.Address2
                    : "";
                formattedAddress =
                  address.City != null || address.City != ""
                    ? formattedAddress + " " + address.City
                    : "";
                formattedAddress =
                  address.State != null || address.State != ""
                    ? formattedAddress + " " + address.State
                    : "";
                formattedAddress =
                  address.Country != null || address.Country != ""
                    ? formattedAddress + " " + address.Country
                    : "";
            }
            else
            {
                formattedAddress = "";
            }

            return formattedAddress;
        }

        public PropertyViewModel GetById(int propertyId)
        {
            var res = _context.Properties.Join(_context.Addresses, p => p.PropertyId, a => a.PropertyId, (p, a) => new { p, a }).Select(m => m);

            return res.ToList().Where(m=>m.p.PropertyId== propertyId).Select(m => new PropertyViewModel
            {
                Id = m.p.PropertyId,
                AccountId = m.p.AccountId,
                MainImageUrl = m.p.MainImageUrl,
                Yearbuilt = m.p.Yearbuilt,
                MonthlyRent = m.p.MonthlyRent,
                ListPrice = m.p.ListPrice,
                GrossYield = m.p.GrossYield,
                Address = this.FormatAddress(m.a)
            }).Take(1).SingleOrDefault();
        }

        public void Insert(AddPropertyModel input)
        {
            try
            {


                //Insert Property
                Property property = new Property();
                property.AccountId = input.AccountId;
                property.ListPrice = input.ListPrice;
                property.MonthlyRent = input.MonthlyRent;
                property.MainImageUrl = input.MainImageUrl;
                property.PropertyId = input.Id;
                property.Yearbuilt = input.Yearbuilt;
                property.GrossYield = (input.ListPrice != null && input.MonthlyRent != null)
          ? (
             Convert.ToDecimal(string.Format("{0:0.00}", (input.MonthlyRent * 12) /
              input.ListPrice
            )))
          : input.ListPrice;
                _context.Properties.Add(property);
                _context.SaveChanges();

                //Insert Address
                Address address = new Address();
                address.Address1 = input.Address1;
                address.Address2 = input.Address2;
                address.City = input.City;
                address.Country = input.Country;
                address.County = input.County;
                address.District = input.District;
                address.Zip = input.Zip;
                address.State = input.State;
                address.PropertyId = input.Id;
                _context.Addresses.Add(address);
                _context.SaveChanges();

                //Insert Images
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
