namespace VetClinicApp
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.groupClientLookUp = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblOr = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tabAppointmentManager = new System.Windows.Forms.TabPage();
            this.tabInvoice = new System.Windows.Forms.TabPage();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.tabLabs = new System.Windows.Forms.TabPage();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.tabManagement = new System.Windows.Forms.TabPage();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.groupClientLookUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHome);
            this.tabControl1.Controls.Add(this.tabAppointmentManager);
            this.tabControl1.Controls.Add(this.tabInvoice);
            this.tabControl1.Controls.Add(this.tabInventory);
            this.tabControl1.Controls.Add(this.tabLabs);
            this.tabControl1.Controls.Add(this.tabReports);
            this.tabControl1.Controls.Add(this.tabSearch);
            this.tabControl1.Controls.Add(this.tabEmployee);
            this.tabControl1.Controls.Add(this.tabManagement);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 414);
            this.tabControl1.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.lblWelcome);
            this.tabHome.Controls.Add(this.groupClientLookUp);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(767, 388);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // groupClientLookUp
            // 
            this.groupClientLookUp.Controls.Add(this.btnSearch);
            this.groupClientLookUp.Controls.Add(this.txtPhoneNumber);
            this.groupClientLookUp.Controls.Add(this.lblPhoneNumber);
            this.groupClientLookUp.Controls.Add(this.lblOr);
            this.groupClientLookUp.Controls.Add(this.lblLastName);
            this.groupClientLookUp.Controls.Add(this.txtLastName);
            this.groupClientLookUp.Controls.Add(this.txtFirstName);
            this.groupClientLookUp.Controls.Add(this.lblFirstName);
            this.groupClientLookUp.Location = new System.Drawing.Point(452, 13);
            this.groupClientLookUp.Name = "groupClientLookUp";
            this.groupClientLookUp.Size = new System.Drawing.Size(291, 360);
            this.groupClientLookUp.TabIndex = 0;
            this.groupClientLookUp.TabStop = false;
            this.groupClientLookUp.Text = "Client Look Up";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(112, 181);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(37, 149);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(225, 20);
            this.txtPhoneNumber.TabIndex = 6;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(26, 132);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 5;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Location = new System.Drawing.Point(132, 114);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(35, 13);
            this.lblOr.TabIndex = 4;
            this.lblOr.Text = "- OR -";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(23, 71);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(37, 87);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(225, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(37, 44);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(225, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(23, 28);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // tabAppointmentManager
            // 
            this.tabAppointmentManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAppointmentManager.Location = new System.Drawing.Point(4, 22);
            this.tabAppointmentManager.Name = "tabAppointmentManager";
            this.tabAppointmentManager.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppointmentManager.Size = new System.Drawing.Size(767, 388);
            this.tabAppointmentManager.TabIndex = 1;
            this.tabAppointmentManager.Text = "Appointment Manager";
            this.tabAppointmentManager.UseVisualStyleBackColor = true;
            // 
            // tabInvoice
            // 
            this.tabInvoice.Location = new System.Drawing.Point(4, 22);
            this.tabInvoice.Name = "tabInvoice";
            this.tabInvoice.Size = new System.Drawing.Size(767, 388);
            this.tabInvoice.TabIndex = 8;
            this.tabInvoice.Text = "Invoice";
            this.tabInvoice.UseVisualStyleBackColor = true;
            // 
            // tabInventory
            // 
            this.tabInventory.Location = new System.Drawing.Point(4, 22);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Size = new System.Drawing.Size(767, 388);
            this.tabInventory.TabIndex = 2;
            this.tabInventory.Text = "Inventory Manager";
            this.tabInventory.UseVisualStyleBackColor = true;
            // 
            // tabLabs
            // 
            this.tabLabs.Location = new System.Drawing.Point(4, 22);
            this.tabLabs.Name = "tabLabs";
            this.tabLabs.Size = new System.Drawing.Size(767, 388);
            this.tabLabs.TabIndex = 3;
            this.tabLabs.Text = "Labs";
            this.tabLabs.UseVisualStyleBackColor = true;
            // 
            // tabReports
            // 
            this.tabReports.Location = new System.Drawing.Point(4, 22);
            this.tabReports.Name = "tabReports";
            this.tabReports.Size = new System.Drawing.Size(767, 388);
            this.tabReports.TabIndex = 4;
            this.tabReports.Text = "Reports";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // tabSearch
            // 
            this.tabSearch.Location = new System.Drawing.Point(4, 22);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Size = new System.Drawing.Size(767, 388);
            this.tabSearch.TabIndex = 5;
            this.tabSearch.Text = "Search";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // tabEmployee
            // 
            this.tabEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Size = new System.Drawing.Size(767, 388);
            this.tabEmployee.TabIndex = 6;
            this.tabEmployee.Text = "Employee Profile";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // tabManagement
            // 
            this.tabManagement.Location = new System.Drawing.Point(4, 22);
            this.tabManagement.Name = "tabManagement";
            this.tabManagement.Size = new System.Drawing.Size(767, 388);
            this.tabManagement.TabIndex = 7;
            this.tabManagement.Text = "Management";
            this.tabManagement.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(6, 13);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(107, 25);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome!";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Vet Clinic, Welcome!";
            this.Load += new System.EventHandler(this.Home_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.groupClientLookUp.ResumeLayout(false);
            this.groupClientLookUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.GroupBox groupClientLookUp;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TabPage tabAppointmentManager;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.TabPage tabLabs;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.TabPage tabManagement;
        private System.Windows.Forms.TabPage tabInvoice;
        private System.Windows.Forms.Label lblWelcome;
    }
}