namespace VetClinicApp
{
    partial class ClientInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientInformation));
            this.grpOwnerInfo = new System.Windows.Forms.GroupBox();
            this.chkEnableEditing = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAltPhoneThree = new System.Windows.Forms.TextBox();
            this.txtAltPhoneTwo = new System.Windows.Forms.TextBox();
            this.txtAltPhoneOne = new System.Windows.Forms.TextBox();
            this.lblAltPhone = new System.Windows.Forms.Label();
            this.txtPhoneThree = new System.Windows.Forms.TextBox();
            this.txtPhoneTwo = new System.Windows.Forms.TextBox();
            this.txtPhoneOne = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnScheduleAppt = new System.Windows.Forms.Button();
            this.btnMoreDetails = new System.Windows.Forms.Button();
            this.btnRemovePet = new System.Windows.Forms.Button();
            this.btnEditPet = new System.Windows.Forms.Button();
            this.btnAddPet = new System.Windows.Forms.Button();
            this.cboState = new System.Windows.Forms.DataGridView();
            this.clmPetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmVaxxDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastCheckup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNextAppt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSpecies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBreed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpOwnerInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboState)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOwnerInfo
            // 
            this.grpOwnerInfo.Controls.Add(this.chkEnableEditing);
            this.grpOwnerInfo.Controls.Add(this.btnDelete);
            this.grpOwnerInfo.Controls.Add(this.btnSave);
            this.grpOwnerInfo.Controls.Add(this.lblEmail);
            this.grpOwnerInfo.Controls.Add(this.txtEmail);
            this.grpOwnerInfo.Controls.Add(this.txtAltPhoneThree);
            this.grpOwnerInfo.Controls.Add(this.txtAltPhoneTwo);
            this.grpOwnerInfo.Controls.Add(this.txtAltPhoneOne);
            this.grpOwnerInfo.Controls.Add(this.lblAltPhone);
            this.grpOwnerInfo.Controls.Add(this.txtPhoneThree);
            this.grpOwnerInfo.Controls.Add(this.txtPhoneTwo);
            this.grpOwnerInfo.Controls.Add(this.txtPhoneOne);
            this.grpOwnerInfo.Controls.Add(this.lblPhoneNumber);
            this.grpOwnerInfo.Controls.Add(this.comboBox1);
            this.grpOwnerInfo.Controls.Add(this.txtZipCode);
            this.grpOwnerInfo.Controls.Add(this.txtCity);
            this.grpOwnerInfo.Controls.Add(this.txtStreetAddress);
            this.grpOwnerInfo.Controls.Add(this.lblZipCode);
            this.grpOwnerInfo.Controls.Add(this.lblState);
            this.grpOwnerInfo.Controls.Add(this.lblCity);
            this.grpOwnerInfo.Controls.Add(this.label1);
            this.grpOwnerInfo.Controls.Add(this.txtLastName);
            this.grpOwnerInfo.Controls.Add(this.txtFirstName);
            this.grpOwnerInfo.Controls.Add(this.lblLastName);
            this.grpOwnerInfo.Controls.Add(this.lblFirstName);
            this.grpOwnerInfo.Location = new System.Drawing.Point(13, 13);
            this.grpOwnerInfo.Name = "grpOwnerInfo";
            this.grpOwnerInfo.Size = new System.Drawing.Size(775, 206);
            this.grpOwnerInfo.TabIndex = 0;
            this.grpOwnerInfo.TabStop = false;
            this.grpOwnerInfo.Text = "Owner Information";
            // 
            // chkEnableEditing
            // 
            this.chkEnableEditing.AutoSize = true;
            this.chkEnableEditing.Location = new System.Drawing.Point(191, 172);
            this.chkEnableEditing.Name = "chkEnableEditing";
            this.chkEnableEditing.Size = new System.Drawing.Size(94, 17);
            this.chkEnableEditing.TabIndex = 25;
            this.chkEnableEditing.Text = "Enable Editing";
            this.chkEnableEditing.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(101, 168);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(20, 168);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(370, 115);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(77, 13);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "E-Mail Address";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(373, 131);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(382, 20);
            this.txtEmail.TabIndex = 21;
            // 
            // txtAltPhoneThree
            // 
            this.txtAltPhoneThree.Location = new System.Drawing.Point(305, 131);
            this.txtAltPhoneThree.Name = "txtAltPhoneThree";
            this.txtAltPhoneThree.Size = new System.Drawing.Size(51, 20);
            this.txtAltPhoneThree.TabIndex = 20;
            // 
            // txtAltPhoneTwo
            // 
            this.txtAltPhoneTwo.Location = new System.Drawing.Point(248, 131);
            this.txtAltPhoneTwo.Name = "txtAltPhoneTwo";
            this.txtAltPhoneTwo.Size = new System.Drawing.Size(51, 20);
            this.txtAltPhoneTwo.TabIndex = 19;
            // 
            // txtAltPhoneOne
            // 
            this.txtAltPhoneOne.Location = new System.Drawing.Point(191, 131);
            this.txtAltPhoneOne.Name = "txtAltPhoneOne";
            this.txtAltPhoneOne.Size = new System.Drawing.Size(51, 20);
            this.txtAltPhoneOne.TabIndex = 18;
            // 
            // lblAltPhone
            // 
            this.lblAltPhone.AutoSize = true;
            this.lblAltPhone.Location = new System.Drawing.Point(188, 115);
            this.lblAltPhone.Name = "lblAltPhone";
            this.lblAltPhone.Size = new System.Drawing.Size(96, 13);
            this.lblAltPhone.TabIndex = 17;
            this.lblAltPhone.Text = "Alt. Phone Number";
            // 
            // txtPhoneThree
            // 
            this.txtPhoneThree.Location = new System.Drawing.Point(134, 130);
            this.txtPhoneThree.Name = "txtPhoneThree";
            this.txtPhoneThree.Size = new System.Drawing.Size(51, 20);
            this.txtPhoneThree.TabIndex = 16;
            // 
            // txtPhoneTwo
            // 
            this.txtPhoneTwo.Location = new System.Drawing.Point(77, 130);
            this.txtPhoneTwo.Name = "txtPhoneTwo";
            this.txtPhoneTwo.Size = new System.Drawing.Size(51, 20);
            this.txtPhoneTwo.TabIndex = 15;
            // 
            // txtPhoneOne
            // 
            this.txtPhoneOne.Location = new System.Drawing.Point(20, 130);
            this.txtPhoneOne.Name = "txtPhoneOne";
            this.txtPhoneOne.Size = new System.Drawing.Size(51, 20);
            this.txtPhoneOne.TabIndex = 14;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(17, 114);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblPhoneNumber.TabIndex = 13;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(560, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(78, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(644, 87);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(111, 20);
            this.txtZipCode.TabIndex = 11;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(373, 88);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(181, 20);
            this.txtCity.TabIndex = 10;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(20, 87);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(336, 20);
            this.txtStreetAddress.TabIndex = 9;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(641, 70);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(50, 13);
            this.lblZipCode.TabIndex = 8;
            this.lblZipCode.Text = "Zip Code";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(557, 70);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 7;
            this.lblState.Text = "State";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(370, 72);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Street Address";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(373, 44);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(382, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(20, 44);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(336, 20);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(370, 28);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(17, 27);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnScheduleAppt);
            this.groupBox1.Controls.Add(this.btnMoreDetails);
            this.groupBox1.Controls.Add(this.btnRemovePet);
            this.groupBox1.Controls.Add(this.btnEditPet);
            this.groupBox1.Controls.Add(this.btnAddPet);
            this.groupBox1.Controls.Add(this.cboState);
            this.groupBox1.Location = new System.Drawing.Point(13, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 213);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pets Inforamtion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(680, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Edit Appt";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnScheduleAppt
            // 
            this.btnScheduleAppt.Location = new System.Drawing.Point(680, 149);
            this.btnScheduleAppt.Name = "btnScheduleAppt";
            this.btnScheduleAppt.Size = new System.Drawing.Size(75, 23);
            this.btnScheduleAppt.TabIndex = 5;
            this.btnScheduleAppt.Text = "New Appt";
            this.btnScheduleAppt.UseVisualStyleBackColor = true;
            // 
            // btnMoreDetails
            // 
            this.btnMoreDetails.Location = new System.Drawing.Point(680, 115);
            this.btnMoreDetails.Name = "btnMoreDetails";
            this.btnMoreDetails.Size = new System.Drawing.Size(75, 23);
            this.btnMoreDetails.TabIndex = 4;
            this.btnMoreDetails.Text = "More Details";
            this.btnMoreDetails.UseVisualStyleBackColor = true;
            // 
            // btnRemovePet
            // 
            this.btnRemovePet.Location = new System.Drawing.Point(680, 81);
            this.btnRemovePet.Name = "btnRemovePet";
            this.btnRemovePet.Size = new System.Drawing.Size(75, 23);
            this.btnRemovePet.TabIndex = 3;
            this.btnRemovePet.Text = "Remove Pet";
            this.btnRemovePet.UseVisualStyleBackColor = true;
            // 
            // btnEditPet
            // 
            this.btnEditPet.Location = new System.Drawing.Point(680, 47);
            this.btnEditPet.Name = "btnEditPet";
            this.btnEditPet.Size = new System.Drawing.Size(75, 23);
            this.btnEditPet.TabIndex = 2;
            this.btnEditPet.Text = "Edit Pet";
            this.btnEditPet.UseVisualStyleBackColor = true;
            // 
            // btnAddPet
            // 
            this.btnAddPet.Location = new System.Drawing.Point(680, 13);
            this.btnAddPet.Name = "btnAddPet";
            this.btnAddPet.Size = new System.Drawing.Size(75, 23);
            this.btnAddPet.TabIndex = 1;
            this.btnAddPet.Text = "Add Pet";
            this.btnAddPet.UseVisualStyleBackColor = true;
            // 
            // cboState
            // 
            this.cboState.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.cboState.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.cboState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cboState.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPetName,
            this.clmDOB,
            this.clmVaxxDate,
            this.clmLastCheckup,
            this.clmNextAppt,
            this.clmSpecies,
            this.clmBreed,
            this.clmGender});
            this.cboState.Location = new System.Drawing.Point(6, 13);
            this.cboState.Name = "cboState";
            this.cboState.RowHeadersWidth = 6;
            this.cboState.Size = new System.Drawing.Size(668, 194);
            this.cboState.TabIndex = 0;
            this.cboState.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clmPetName
            // 
            this.clmPetName.HeaderText = "Pet Name";
            this.clmPetName.Name = "clmPetName";
            this.clmPetName.Width = 73;
            // 
            // clmDOB
            // 
            this.clmDOB.HeaderText = "D/O/B";
            this.clmDOB.Name = "clmDOB";
            this.clmDOB.Width = 65;
            // 
            // clmVaxxDate
            // 
            this.clmVaxxDate.HeaderText = "Vaccines Needed On";
            this.clmVaxxDate.Name = "clmVaxxDate";
            this.clmVaxxDate.Width = 110;
            // 
            // clmLastCheckup
            // 
            this.clmLastCheckup.HeaderText = "Last Check Up";
            this.clmLastCheckup.Name = "clmLastCheckup";
            this.clmLastCheckup.Width = 82;
            // 
            // clmNextAppt
            // 
            this.clmNextAppt.HeaderText = "Next Appointment";
            this.clmNextAppt.Name = "clmNextAppt";
            this.clmNextAppt.Width = 106;
            // 
            // clmSpecies
            // 
            this.clmSpecies.HeaderText = "Species";
            this.clmSpecies.Name = "clmSpecies";
            this.clmSpecies.Width = 70;
            // 
            // clmBreed
            // 
            this.clmBreed.HeaderText = "Breed";
            this.clmBreed.Name = "clmBreed";
            this.clmBreed.Width = 60;
            // 
            // clmGender
            // 
            this.clmGender.HeaderText = "Gender";
            this.clmGender.Name = "clmGender";
            this.clmGender.Width = 67;
            // 
            // ClientInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpOwnerInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientInformation";
            this.Text = "Client Information";
            this.Load += new System.EventHandler(this.ClientInformation_Load);
            this.grpOwnerInfo.ResumeLayout(false);
            this.grpOwnerInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOwnerInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAltPhoneThree;
        private System.Windows.Forms.TextBox txtAltPhoneTwo;
        private System.Windows.Forms.TextBox txtAltPhoneOne;
        private System.Windows.Forms.Label lblAltPhone;
        private System.Windows.Forms.TextBox txtPhoneThree;
        private System.Windows.Forms.TextBox txtPhoneTwo;
        private System.Windows.Forms.TextBox txtPhoneOne;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView cboState;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnScheduleAppt;
        private System.Windows.Forms.Button btnMoreDetails;
        private System.Windows.Forms.Button btnRemovePet;
        private System.Windows.Forms.Button btnEditPet;
        private System.Windows.Forms.Button btnAddPet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVaxxDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLastCheckup;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNextAppt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSpecies;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBreed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGender;
        private System.Windows.Forms.CheckBox chkEnableEditing;
    }
}