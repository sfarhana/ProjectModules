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
    public partial class ProductCategoryUi : Form
    {
        public ProductCategoryUi()
        {
            InitializeComponent();
        }
        int CategoryId;
        CategoryManager _CM = new CategoryManager();
        private void ProductCategoryUi_Load(object sender, EventArgs e)
        {
            categoryGridView.DataSource = _CM.LoadCategoryInfo();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (btnSave.Text == "Save")
            {
                bool isChecked = FieldCheck();
                if (isChecked == true)
                {
                    SaveCategoryInfo();
                }
                else
                    return;
            }

            else
            {
                bool isChecked = FieldCheck();
                if (isChecked == true)
                {
                    UpdateCategoryInfo();
                }
                else
                    return;
            }
        }

            public bool FieldCheck()
            {
                try
                {
                    if (string.IsNullOrEmpty(txtCategoryCode.Text))
                    {
                        MessageBox.Show("Code field can not be Empty");
                        return false;
                    }

                    if (txtCategoryCode.Text.Length != 4)
                    {
                        MessageBox.Show("Code Should Be 4 Char Length");
                        return false;
                    }

                    bool isCode = _CM.IsCodeUnique(txtCategoryCode.Text,CategoryId);

                    if (isCode == true)
                    {
                        MessageBox.Show("Code must be unique");
                        return false;

                    }

                    if (string.IsNullOrEmpty(txtCategoryName.Text))
                    {
                        MessageBox.Show("Name field can not be Empty");
                        return false;
                    }

                    bool isName = _CM.IsNameUnique(txtCategoryName.Text, CategoryId);

                    if (isName == true)
                    {
                        MessageBox.Show("Category Name must be unique");
                        return false;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Field Checking Error " + ex.Message.ToString());
                }

                return true;
            }

            public void SaveCategoryInfo()
            {
                try
                {
                    Category ctg = new Category();
                    ctg.CategoryCode = txtCategoryCode.Text;
                    ctg.CategoryName = txtCategoryName.Text;

                    bool isSave = _CM.InsertCategory(ctg);
                    if (isSave == true)
                    {
                        MessageBox.Show("Data saved");
                        ClearControls();//to get ready for update
                        categoryGridView.DataSource = _CM.LoadCategoryInfo();
                    }
                    else
                        MessageBox.Show("Data save Failed");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Insertion Error " + ex.Message.ToString());
                }

            }

        public void UpdateCategoryInfo()
        {
            try
            {
                Category ctg = new Category();

                ctg.CategoryId = CategoryId;
                ctg.CategoryCode = txtCategoryCode.Text;
                ctg.CategoryName = txtCategoryName.Text;

                bool isUpdate = _CM.UpdateCategory(ctg);

                if (isUpdate == true)
                {
                    MessageBox.Show("Update Successfully");
                    ClearControls();
                    categoryGridView.DataSource = _CM.LoadCategoryInfo();
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
                txtCategoryCode.Text = "";
                txtCategoryName.Text = "";
            }

            private void categoryGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
            {
                this.categoryGridView.Rows[e.RowIndex].Cells["Sl"].Value = (e.RowIndex + 1).ToString();
            }

            private void categoryGridView_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                int currentRow = int.Parse(e.RowIndex.ToString());
                int currentColumnIndex = int.Parse(e.ColumnIndex.ToString());
                if (currentColumnIndex == 4)
                {
                    CategoryId = Convert.ToInt16(categoryGridView.Rows[currentRow].Cells["categoryIdDataGridViewTextBoxColumn"].Value.ToString());
                    txtCategoryCode.Text = categoryGridView.Rows[currentRow].Cells["categoryCodeDataGridViewTextBoxColumn"].Value.ToString();
                    txtCategoryName.Text = categoryGridView.Rows[currentRow].Cells["categoryNameDataGridViewTextBoxColumn"].Value.ToString();

                    btnSave.Text = "Update"; 
                }
            }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                categoryGridView.DataSource = _CM.SearchCategoryName(txtSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error" + ex.Message.ToString());
            }
            
        }
    }
}
