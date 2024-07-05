using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLoanManagementAPI.Core.Database.Entities
{
    public class Car
    {
        
        public int CarID { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        public string? VIN { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
