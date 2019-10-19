using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessManagementSystem.BLL;
using BusinessManagementSystem.Model;

namespace BusinessManagementSystem
{
    public partial class CustomerUi : Form
    {
        public CustomerUi()
        {
            InitializeComponent();
        }
        int CustID;
        CustomerManager _CM = new CustomerManager();

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                bool isChecked = FieldCheck();
                if (isChecked == true)
                {
                    SaveCustomerInfo();
                }
                else
                    return;
            }

            else
            {
                bool isChecked = FieldCheck();
                if (isChecked == true)
                {
                    UpdateCustomerInfo();
                }
                else
                    return;
            }
        }

        public bool FieldCheck()
        {
            try
            {
                if (string.IsNullOrEmpty(txtCustCode.Text))
                {
                    MessageBox.Show("CustCode field can not be Empty");
                    return false;
                }

                if (txtCustCode.Text.Length != 4)
                {
                    MessageBox.Show("CustCode Should Be 4 Char Length");
                    return false;
                }

                bool isCode = _CM.IsCodeUnique(txtCustCode.Text, CustID);

                if (isCode == true)
                {
                    MessageBox.Show("CustCode must be unique");
                    return false;

                }

                if (string.IsNullOrEmpty(txtCustName.Text))
                {
                    MessageBox.Show("Name field can not be Empty");
                    return false;
                }

                if (string.IsNullOrEmpty(txtCustEmail.Text))
                {
                    MessageBox.Show("Email field can not be Empty");
                    return false;
                }

                bool isMail = _CM.IsMailUnique(txtCustEmail.Text, CustID);

                if (isCode == true)
                {
                    MessageBox.Show("Email must be unique");
                    return false;

                }

                if (string.IsNullOrEmpty(txtCustContact.Text))
                {
                    MessageBox.Show("Contact field can not be Empty");
                    return false;
                }

                bool isContact = _CM.IsContactUnique(txtCustContact.Text, CustID);

                if (isCode == true)
                {
                    MessageBox.Show("Contact must be unique");
                    return false;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Field Checking Error " + ex.Message.ToString());
            }

            return true;
        }

        public void SaveCustomerInfo()
        {
            try
            {
                Customer cust = new Customer();
                cust.CustCode = txtCustCode.Text;
                cust.CustName = txtCustName.Text;
                cust.CustAddress = txtCustAddress.Text;
                cust.CustEmail = txtCustEmail.Text;
                cust.CustContact = txtCustContact.Text;
                cust.CustLoyaltyPoint = Convert.ToInt16(txtLoyaltyPoint.Text);

                bool isSave = _CM.InsertCustomer(cust);
                if (isSave == true)
                {
                    MessageBox.Show("Data saved");
                    ClearControls();//to get ready for update
                    customerGridView.DataSource = _CM.LoadCustomerInfo();
                }
                else
                    MessageBox.Show("Data save Failed");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Insertion Error " + ex.Message.ToString());
            }

        }

        public void UpdateCustomerInfo()
        {
            try
            {
                Customer cust = new Customer();

                cust.CustID = CustID;
                cust.CustCode = txtCustCode.Text;
                cust.CustName = txtCustName.Text;
                cust.CustAddress = txtCustAddress.Text;
                cust.CustEmail = txtCustEmail.Text;
                cust.CustContact = txtCustContact.Text;
                cust.CustLoyaltyPoint = Convert.ToInt16(txtLoyaltyPoint.Text);

                bool isUpdate = _CM.UpdateCustomer(cust);

                if (isUpdate == true)
                {
                    MessageBox.Show("Update Successfully");
                    ClearControls();
                    customerGridView.DataSource = _CM.LoadCustomerInfo();
                    btnSave.Text = "Save";
                }
                else
                {
                    MessageBox.Show("Update Failed");
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show("Update Error" + ex.Message.ToString());
            }

        }

        public void ClearControls()
        {
            txtCustCode.Text = "";
            txtCustName.Text = "";
            txtCustAddress.Text = "";
            txtCustEmail.Text = "";
            txtCustContact.Text = "";
            txtLoyaltyPoint.Text = "";

        }

        private void customerGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.customerGridView.Rows[e.RowIndex].Cells["Sl"].Value = (e.RowIndex + 1).ToString();
        }

        private void CustomerUi_Load(object sender, EventArgs e)
        {
            customerGridView.DataSource = _CM.LoadCustomerInfo();
        }

        private void customerGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = int.Parse(e.RowIndex.ToString());
            int currentColumnIndex = int.Parse(e.ColumnIndex.ToString());
            if (currentColumnIndex == 8)
            {
                CustID = Convert.ToInt16(customerGridView.Rows[currentRow].Cells["custIDDataGridViewTextBoxColumn"].Value.ToString());

                txtCustCode.Text = customerGridView.Rows[currentRow].Cells["custCodeDataGridViewTextBoxColumn"].Value.ToString();
                txtCustName.Text = customerGridView.Rows[currentRow].Cells["custNameDataGridViewTextBoxColumn"].Value.ToString();
                txtCustAddress.Text= customerGridView.Rows[currentRow].Cells["custAddressDataGridViewTextBoxColumn"].Value.ToString();
                txtCustEmail.Text= customerGridView.Rows[currentRow].Cells["custEmailDataGridViewTextBoxColumn"].Value.ToString();
                txtCustContact.Text= customerGridView.Rows[currentRow].Cells["custContactDataGridViewTextBoxColumn"].Value.ToString();
                txtLoyaltyPoint.Text= customerGridView.Rows[currentRow].Cells["custLoyaltyPointDataGridViewTextBoxColumn"].Value.ToString();

                btnSave.Text = "Update";
            }
        }
    }
}
