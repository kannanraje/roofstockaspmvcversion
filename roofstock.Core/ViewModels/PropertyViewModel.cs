using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roofstock.Core.ViewModels
{
   public class PropertyViewModel
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public string MainImageUrl { get; set; }
        public Nullable<int> Yearbuilt { get; set; }
        public Nullable<decimal> ListPrice { get; set; }
        public Nullable<decimal> MonthlyRent { get; set; }
        public Nullable<decimal> GrossYield { get; set; }
        public string Address { get; set; }
    }
}
