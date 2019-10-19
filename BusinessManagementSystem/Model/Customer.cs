using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementSystem.Model
{
    public class Customer
    {
        public int CustID { get; set; }
        public string CustCode { get; set; }
        public string CustName { get; set; }
        public string CustAddress { get; set; }
        public string CustEmail { get; set; }
        public string CustContact { get; set; }
        public int CustLoyaltyPoint { get; set; }

    }
}
