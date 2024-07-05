using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLoanManagementAPI.Core.Database.Entities
{
    public class LoanApplication
    {

        public int LoanApplicationID { get; set; }
        public int CustomerID { get; set; }
        public int CarID { get; set; }
        public int LoanID { get; set; }
        public string? ApplicationStatus { get; set; }
        public DateTime ApplicationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Customer? Customer { get; set; }
        public Car? Car { get; set; }
        public Loan? Loan { get; set; }
    }
}
