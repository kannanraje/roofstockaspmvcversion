using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roofstock.Core.Models
{
    public class AddPropertyModel
    {
        [Display(Name = "Property Id")]
        [Required(ErrorMessage = "Property Id is required.")]
        public long Id { get; set; }
        [Required(ErrorMessage = "Account Id is required.")]        
        public long AccountId { get; set; }
        [Required(ErrorMessage = "Image Url is required.")]
        public string MainImageUrl { get; set; }
        [Required(ErrorMessage = "Year built is required.")]
        public Nullable<int> Yearbuilt { get; set; }
        [Required(ErrorMessage = "List Price is required.")]
        public Nullable<decimal> ListPrice { get; set; }
        [Required(ErrorMessage = "Monthly Rent is required.")]
        public Nullable<decimal> MonthlyRent { get; set; }
        [Required(ErrorMessage = "Address1  is required.")]
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        [Required(ErrorMessage = "City  is required.")]
        public string City { get; set; }
        [Required(ErrorMessage = "Country  is required.")]
        public string Country { get; set; }
        public string County { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}
