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
    public class CategoryRepository
    {
        public bool IsCodeUnique(string Code,int CategoryId)
        {
            try
            {
                string cmdstring = "";
                string connstring = @"server=FARHANAMOSTO-PC;database=SmallBusMgt;Integrated security=true";
                SqlConnection conn = new SqlConnection(connstring);
                conn.Open();

                if(Code != null && CategoryId == 0)
                {
                    cmdstring = @"select * from ProductCategory where CategoryCode='" + Code + "'";
                }

                else if (Code != null && CategoryId > 0)
                {
                   cmdstring = @"select * from ProductCategory where CategoryCode='" + Code + "'" + " and CategoryId!=" + CategoryId.ToString();
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

        public bool IsNameUnique(string Name,int CategoryId)
        {
            try
            {
                string cmdstring = "";
                string connstring = @"server=FARHANAMOSTO-PC;database=SmallBusMgt;Integrated security=true";
                SqlConnection conn = new SqlConnection(connstring);
                conn.Open();

                if (Name != null && CategoryId == 0)
                {
                    cmdstring = @"select * from ProductCategory where CategoryName='" + Name + "'";
                }

                else if (Name != null && CategoryId > 0)
                {
                    cmdstring = @"select * from ProductCategory where CategoryName='" + Name + "'" + " and CategoryId!=" + CategoryId.ToString();
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

        public bool InsertCategory(Category ctg)
        {
            try
            {
                string connstring = @"server=FARHANAMOSTO-PC; Database =SmallBusMgt ;Integrated Security=true";
                SqlConnection conn = new SqlConnection(connstring);
                conn.Open();

                string cmdstring = @"Insert into ProductCategory(CategoryCode,CategoryName) values('" + ctg.CategoryCode + "','" + ctg.CategoryName + "')";
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

        public DataTable LoadCategoryInfo()
        {
            try
            {
                string connstring = @"server=FARHANAMOSTO-PC; Database = SmallBusMgt;Integrated Security=true";
                SqlConnection conn = new SqlConnection(connstring);
                conn.Open();

                string cmdstring = @"select * from ProductCategory";
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

        public bool UpdateCategory(Category ctg)
        {
            try
            {
                string connstring = @"server=FARHANAMOSTO-PC; Database = SmallBusMgt;Integrated Security=true";
                SqlConnection conn = new SqlConnection(connstring);
                conn.Open();

                string cmdstring = @"update ProductCategory set CategoryCode='" + ctg.CategoryCode + "',CategoryName='" + ctg.CategoryName + "'where CategoryId=" + ctg.CategoryId;
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

        public DataTable SearchCategoryName(string Name)
        {
            try
            {
                string ConnectionString = @"server=FARHANAMOSTO-PC;Database=SmallBusMgt;Integrated Security=True";
                SqlConnection sqlconnection = new SqlConnection(ConnectionString);
                sqlconnection.Open();

                string CommandString = @"select * from ProductCategory where CategoryName='" + Name + "'";
                SqlCommand sqlcommand = new SqlCommand(CommandString, sqlconnection);

                SqlDataAdapter sqladapter = new SqlDataAdapter(sqlcommand);
                DataTable datatable = new DataTable();
                sqladapter.Fill(datatable);
                sqlconnection.Close();

                if (datatable.Rows.Count > 0)
                {
                    return datatable;
                }
                else
                {
                    return null;

                }
            }

            catch (SqlException)
            {
                throw;
            }
        }


    }
}
