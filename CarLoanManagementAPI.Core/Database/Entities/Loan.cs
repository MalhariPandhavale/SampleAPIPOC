using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLoanManagementAPI.Core.Database.Entities
{
    public class Loan
    {
        public int LoanID { get; set; }
        public decimal LoanAmount { get; set; }
        public float InterestRate { get; set; }
        public int LoanTerm { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
