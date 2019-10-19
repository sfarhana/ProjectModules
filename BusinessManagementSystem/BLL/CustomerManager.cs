using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BusinessManagementSystem.Repository;
using BusinessManagementSystem.Model;

namespace BusinessManagementSystem.BLL
{
   public class CustomerManager
    {
        CustomerRepository _CR = new CustomerRepository();

        public bool IsCodeUnique(string CustCode, int CustID)
        {
            return _CR.IsCodeUnique(CustCode, CustID);
        }

        public bool IsMailUnique(string CustEmail, int CustID)
        {
            return _CR.IsMailUnique(CustEmail, CustID);
        }

        public bool IsContactUnique(string CustContact, int CustID)
        {
            return _CR.IsContactUnique(CustContact,CustID);
        }

        public bool InsertCustomer(Customer cust)
        {
            return _CR.InsertCustomer(cust);
        }

        public DataTable LoadCustomerInfo()
        {
            return _CR.LoadCustomerInfo();
        }

        public bool UpdateCustomer(Customer cust)
        {
            return _CR.UpdateCustomer(cust);
        }
    }
}
