namespace BusinessManagementSystem
{
    partial class CustomerUi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtCustCode = new System.Windows.Forms.TextBox();
            this.txtLoyaltyPoint = new System.Windows.Forms.TextBox();
            this.txtCustContact = new System.Windows.Forms.TextBox();
            this.txtCustEmail = new System.Windows.Forms.TextBox();
            this.txtCustAddress = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custLoyaltyPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButtton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustCode
            // 
            this.txtCustCode.Location = new System.Drawing.Point(272, 12);
            this.txtCustCode.Name = "txtCustCode";
            this.txtCustCode.Size = new System.Drawing.Size(100, 20);
            this.txtCustCode.TabIndex = 0;
            // 
            // txtLoyaltyPoint
            // 
            this.txtLoyaltyPoint.Location = new System.Drawing.Point(272, 142);
            this.txtLoyaltyPoint.Name = "txtLoyaltyPoint";
            this.txtLoyaltyPoint.Size = new System.Drawing.Size(100, 20);
            this.txtLoyaltyPoint.TabIndex = 1;
            this.txtLoyaltyPoint.Text = "0";
            // 
            // txtCustContact
            // 
            this.txtCustContact.Location = new System.Drawing.Point(272, 116);
            this.txtCustContact.Name = "txtCustContact";
            this.txtCustContact.Size = new System.Drawing.Size(100, 20);
            this.txtCustContact.TabIndex = 2;
            // 
            // txtCustEmail
            // 
            this.txtCustEmail.Location = new System.Drawing.Point(272, 90);
            this.txtCustEmail.Name = "txtCustEmail";
            this.txtCustEmail.Size = new System.Drawing.Size(100, 20);
            this.txtCustEmail.TabIndex = 3;
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.Location = new System.Drawing.Point(272, 64);
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(100, 20);
            this.txtCustAddress.TabIndex = 4;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(272, 38);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(100, 20);
            this.txtCustName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Loyalty Point";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(272, 168);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // customerGridView
            // 
            this.customerGridView.AllowUserToAddRows = false;
            this.customerGridView.AutoGenerateColumns = false;
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sl,
            this.custIDDataGridViewTextBoxColumn,
            this.custCodeDataGridViewTextBoxColumn,
            this.custNameDataGridViewTextBoxColumn,
            this.custAddressDataGridViewTextBoxColumn,
            this.custEmailDataGridViewTextBoxColumn,
            this.custContactDataGridViewTextBoxColumn,
            this.custLoyaltyPointDataGridViewTextBoxColumn,
            this.EditButtton});
            this.customerGridView.DataSource = this.customerBindingSource;
            this.customerGridView.Location = new System.Drawing.Point(28, 197);
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.Size = new System.Drawing.Size(747, 241);
            this.customerGridView.TabIndex = 13;
            this.customerGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerGridView_CellClick);
            this.customerGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.customerGridView_RowPostPaint);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(BusinessManagementSystem.Model.Customer);
            // 
            // Sl
            // 
            this.Sl.HeaderText = "Sl";
            this.Sl.Name = "Sl";
            // 
            // custIDDataGridViewTextBoxColumn
            // 
            this.custIDDataGridViewTextBoxColumn.DataPropertyName = "CustID";
            this.custIDDataGridViewTextBoxColumn.HeaderText = "CustID";
            this.custIDDataGridViewTextBoxColumn.Name = "custIDDataGridViewTextBoxColumn";
            // 
            // custCodeDataGridViewTextBoxColumn
            // 
            this.custCodeDataGridViewTextBoxColumn.DataPropertyName = "CustCode";
            this.custCodeDataGridViewTextBoxColumn.HeaderText = "CustCode";
            this.custCodeDataGridViewTextBoxColumn.Name = "custCodeDataGridViewTextBoxColumn";
            // 
            // custNameDataGridViewTextBoxColumn
            // 
            this.custNameDataGridViewTextBoxColumn.DataPropertyName = "CustName";
            this.custNameDataGridViewTextBoxColumn.HeaderText = "CustName";
            this.custNameDataGridViewTextBoxColumn.Name = "custNameDataGridViewTextBoxColumn";
            // 
            // custAddressDataGridViewTextBoxColumn
            // 
            this.custAddressDataGridViewTextBoxColumn.DataPropertyName = "CustAddress";
            this.custAddressDataGridViewTextBoxColumn.HeaderText = "CustAddress";
            this.custAddressDataGridViewTextBoxColumn.Name = "custAddressDataGridViewTextBoxColumn";
            // 
            // custEmailDataGridViewTextBoxColumn
            // 
            this.custEmailDataGridViewTextBoxColumn.DataPropertyName = "CustEmail";
            this.custEmailDataGridViewTextBoxColumn.HeaderText = "CustEmail";
            this.custEmailDataGridViewTextBoxColumn.Name = "custEmailDataGridViewTextBoxColumn";
            // 
            // custContactDataGridViewTextBoxColumn
            // 
            this.custContactDataGridViewTextBoxColumn.DataPropertyName = "CustContact";
            this.custContactDataGridViewTextBoxColumn.HeaderText = "CustContact";
            this.custContactDataGridViewTextBoxColumn.Name = "custContactDataGridViewTextBoxColumn";
            // 
            // custLoyaltyPointDataGridViewTextBoxColumn
            // 
            this.custLoyaltyPointDataGridViewTextBoxColumn.DataPropertyName = "CustLoyaltyPoint";
            this.custLoyaltyPointDataGridViewTextBoxColumn.HeaderText = "CustLoyaltyPoint";
            this.custLoyaltyPointDataGridViewTextBoxColumn.Name = "custLoyaltyPointDataGridViewTextBoxColumn";
            // 
            // EditButtton
            // 
            this.EditButtton.HeaderText = "Action";
            this.EditButtton.Name = "EditButtton";
            this.EditButtton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditButtton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EditButtton.Text = "Edit";
            this.EditButtton.UseColumnTextForButtonValue = true;
            // 
            // CustomerUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerGridView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.txtCustAddress);
            this.Controls.Add(this.txtCustEmail);
            this.Controls.Add(this.txtCustContact);
            this.Controls.Add(this.txtLoyaltyPoint);
            this.Controls.Add(this.txtCustCode);
            this.Name = "CustomerUi";
            this.Text = "CustomerUi";
            this.Load += new System.EventHandler(this.CustomerUi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustCode;
        private System.Windows.Forms.TextBox txtLoyaltyPoint;
        private System.Windows.Forms.TextBox txtCustContact;
        private System.Windows.Forms.TextBox txtCustEmail;
        private System.Windows.Forms.TextBox txtCustAddress;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView customerGridView;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custLoyaltyPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditButtton;
    }
}