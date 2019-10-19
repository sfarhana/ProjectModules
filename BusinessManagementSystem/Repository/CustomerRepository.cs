using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BusinessManagementSystem.Model;

namespace BusinessManagementSystem.Repository
{
    public class CustomerRepository
    {
        public bool IsCodeUnique(string CustCode, int CustID)
        {
            try
            {
                string cmdstring = "";
                string connstring = @"server=FARHANAMOSTO-PC;database=SmallBusMgt;Integrated security=true";
                SqlConnection conn = new SqlConnection(connstring);
                conn.Open();

                if (CustCode != null && CustID == 0)
                {
                    cmdstring = @"select * from Customer where CustCode='" + CustCode + "'";
                }

                else if (CustCode != null && CustID > 0)
                {
                    cmdstring = @"select * from Customer where CustCode='" + CustCode + "'" + " and CustID!=" + CustID.ToString();
                }

                SqlCommand sqlcmd = new SqlCommand(cmdstring, conn);

                SqlDataAdapter sqladapter = new SqlDataAdapter(sqlcmd);

                DataTable datatable = new DataTable();
                sqladapter.Fill(datatable);
                conn.Close();

                if (datatable.Rows.Count > 0)
                {
                    return true;
                }
                else
                    return false;

            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool IsMailUnique(string CustEmail, int CustID)
        {
            try
            {
                string cmdstring = "";
                string connstring = @"server=FARHANAMOSTO-PC;database=SmallBusMgt;Integrated security=true";
                SqlConnection conn = new SqlConnection(connstring);
                conn.Open();

                if (CustEmail != null && CustID == 0)
                {
                    cmdstring = @"select * from Customer where CustEmail='" + CustEmail + "'";
                }

                else if (CustEmail != null && CustID > 0)
                {
                    cmdstring = @"select * from Customer where CustEmail='" + CustEmail + "'" + " and CustID!=" + CustID.ToString();
                }

                SqlCommand sqlcmd = new SqlCommand(cmdstring, conn);

                SqlDataAdapter sqladapter = new SqlDataAdapter(sqlcmd);

                DataTable datatable = new DataTable();
                sqladapter.Fill(datatable);
                conn.Close();

                if (datatable.Rows.Count > 0)
                {
                    return true;
                }
                else
                    return false;

            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool IsContactUnique(string CustContact, int CustID)
        {
            try
            {
                string cmdstring = "";
                string connstring = @"server=FARHANAMOSTO-PC;database=SmallBusMgt;Integrated security=true";
                SqlConnection conn = new SqlConnection(connstring);
                conn.Open();

                if (CustContact != null && CustID == 0)
                {
                    cmdstring = @"select * from Customer where CustContact='" + CustContact + "'";
                }

                else if (CustContact != null && CustID > 0)
                {
                    cmdstring = @"select * from Customer where CustContact='" + CustContact + "'" + " and CustID!=" + CustID.ToString();
                }

                SqlCommand sqlcmd = new SqlCommand(cmdstring, conn);

                SqlDataAdapter sqladapter = new SqlDataAdapter(sqlcmd);

                DataTable datatable = new DataTable();
                sqladapter.Fill(datatable);
                conn.Close();

                if (datatable.Rows.Count > 0)
                {
                    return true;
                }
                else
                    return false;

            }
            catch (Exception)
            {

                throw;
            }

        }

        public bool InsertCustomer(Customer cust)
        {
            try
            {
                string connstring = @"server=FARHANAMOSTO-PC; Database =SmallBusMgt ;Integrated Security=true";
                SqlConnection conn = new SqlConnection(connstring);
                conn.Open();

                string cmdstring = @"Insert into Customer(CustCode,CustName,CustAddress,CustEmail,CustContact,CustLoyaltyPoint) values
                                   ('" + cust.CustCode+"','"+cust.CustName+"','"+cust.CustAddress+"','"+cust.CustEmail+"','"+cust.CustContact+"','"+cust.CustLoyaltyPoint.ToString()+"')";
                SqlCommand cmd = new SqlCommand(cmdstring, conn);

                int isExecuted = cmd.ExecuteNonQuery();
                conn.Close();

                if (isExecuted > 0)
                {
                    return true;
                }
                else
                    return false;
            }

            catch (Exception)
            {

                throw;
            }

        }

        public DataTable LoadCustomerInfo()
        {
            try
            {
                string connstring = @"server=FARHANAMOSTO-PC; Database = SmallBusMgt;Integrated Security=true";
                SqlConnection conn = new SqlConnection(connstring);
                conn.Open();

                string cmdstring = @"select * from Customer";
                SqlCommand cmd = new SqlCommand(cmdstring, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                conn.Close();

                if (datatable.Rows.Count > 0)
                {
                    return datatable;
                }
                else
                    return null;
            }

            catch (Exception)
            {

                throw;
            }

        }

        public bool UpdateCustomer(Customer cust)
        {
            try
            {
                string connstring = @"server=FARHANAMOSTO-PC; Database = SmallBusMgt;Integrated Security=true";
                SqlConnection conn = new SqlConnection(connstring);
                conn.Open();

                string cmdstring = @"update Customer set CustCode='" + cust.CustCode + "',CustName='" + cust.CustName + "',CustAddress='" + cust.CustAddress +
                                   "',CustEmail='" + cust.CustEmail + "',CustContact='" + cust.CustEmail + "',CustLoyaltyPoint=" + cust.CustLoyaltyPoint +
                                   "where CustID=" + cust.CustID;

                SqlCommand cmd = new SqlCommand(cmdstring, conn);

                int isExecuted = cmd.ExecuteNonQuery();
                conn.Close();

                if (isExecuted > 0)
                {
                    return true;
                }
                else
                    return false;
            }

            catch (Exception)
            {

                throw;
            }
        }

    }
}
