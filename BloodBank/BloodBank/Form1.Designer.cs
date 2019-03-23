namespace BloodBank
{
    partial class Form1
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtBloodGroup = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPatients = new System.Windows.Forms.TabPage();
            this.tabDonors = new System.Windows.Forms.TabPage();
            this.tabBloodBank = new System.Windows.Forms.TabPage();
            this.txtpID = new System.Windows.Forms.TextBox();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.PatientsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BloodGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.bbID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bbName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bbDonor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfDonation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bbAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dBloodGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddDonor = new System.Windows.Forms.Button();
            this.txtdID = new System.Windows.Forms.TextBox();
            this.txtdAddress = new System.Windows.Forms.TextBox();
            this.txtdBloodGroup = new System.Windows.Forms.TextBox();
            this.txtdMiddleName = new System.Windows.Forms.TextBox();
            this.txtdLastName = new System.Windows.Forms.TextBox();
            this.txtdFirstName = new System.Windows.Forms.TextBox();
            this.txtdContactNumber = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtbbID = new System.Windows.Forms.TextBox();
            this.txtbbBBA = new System.Windows.Forms.TextBox();
            this.txtbbBOD = new System.Windows.Forms.TextBox();
            this.txtbbBloodDonor = new System.Windows.Forms.TextBox();
            this.txtbbName = new System.Windows.Forms.TextBox();
            this.btnAddBB = new System.Windows.Forms.Button();
            this.btnEditPatient = new System.Windows.Forms.Button();
            this.btnUpdatePatient = new System.Windows.Forms.Button();
            this.btnUpdateDonor = new System.Windows.Forms.Button();
            this.btnEditDonor = new System.Windows.Forms.Button();
            this.btnUpdateBB = new System.Windows.Forms.Button();
            this.btnEditBB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabs.SuspendLayout();
            this.tabPatients.SuspendLayout();
            this.tabDonors.SuspendLayout();
            this.tabBloodBank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(770, 74);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(252, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientsID,
            this.FirstName,
            this.LastName,
            this.MiddleName,
            this.BloodGroup,
            this.Address,
            this.ContactNumber});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(755, 506);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(770, 246);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(252, 20);
            this.txtAddress.TabIndex = 2;
            // 
            // txtBloodGroup
            // 
            this.txtBloodGroup.Location = new System.Drawing.Point(770, 199);
            this.txtBloodGroup.Name = "txtBloodGroup";
            this.txtBloodGroup.Size = new System.Drawing.Size(252, 20);
            this.txtBloodGroup.TabIndex = 3;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(770, 155);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(252, 20);
            this.txtMiddleName.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(770, 112);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(252, 20);
            this.txtLastName.TabIndex = 5;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPatients);
            this.tabs.Controls.Add(this.tabDonors);
            this.tabs.Controls.Add(this.tabBloodBank);
            this.tabs.Location = new System.Drawing.Point(61, 37);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1053, 575);
            this.tabs.TabIndex = 6;
            // 
            // tabPatients
            // 
            this.tabPatients.Controls.Add(this.btnUpdatePatient);
            this.tabPatients.Controls.Add(this.btnEditPatient);
            this.tabPatients.Controls.Add(this.txtContactNumber);
            this.tabPatients.Controls.Add(this.btnAddPatient);
            this.tabPatients.Controls.Add(this.txtpID);
            this.tabPatients.Controls.Add(this.dataGridView1);
            this.tabPatients.Controls.Add(this.txtAddress);
            this.tabPatients.Controls.Add(this.txtBloodGroup);
            this.tabPatients.Controls.Add(this.txtMiddleName);
            this.tabPatients.Controls.Add(this.txtLastName);
            this.tabPatients.Controls.Add(this.txtFirstName);
            this.tabPatients.Location = new System.Drawing.Point(4, 22);
            this.tabPatients.Name = "tabPatients";
            this.tabPatients.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatients.Size = new System.Drawing.Size(1045, 549);
            this.tabPatients.TabIndex = 0;
            this.tabPatients.Text = "Patients";
            this.tabPatients.UseVisualStyleBackColor = true;
            // 
            // tabDonors
            // 
            this.tabDonors.Controls.Add(this.btnUpdateDonor);
            this.tabDonors.Controls.Add(this.btnEditDonor);
            this.tabDonors.Controls.Add(this.txtdContactNumber);
            this.tabDonors.Controls.Add(this.btnAddDonor);
            this.tabDonors.Controls.Add(this.txtdID);
            this.tabDonors.Controls.Add(this.txtdAddress);
            this.tabDonors.Controls.Add(this.txtdBloodGroup);
            this.tabDonors.Controls.Add(this.txtdMiddleName);
            this.tabDonors.Controls.Add(this.txtdLastName);
            this.tabDonors.Controls.Add(this.txtdFirstName);
            this.tabDonors.Controls.Add(this.dataGridView2);
            this.tabDonors.Location = new System.Drawing.Point(4, 22);
            this.tabDonors.Name = "tabDonors";
            this.tabDonors.Padding = new System.Windows.Forms.Padding(3);
            this.tabDonors.Size = new System.Drawing.Size(1045, 549);
            this.tabDonors.TabIndex = 1;
            this.tabDonors.Text = "Donors";
            this.tabDonors.UseVisualStyleBackColor = true;
            // 
            // tabBloodBank
            // 
            this.tabBloodBank.Controls.Add(this.btnUpdateBB);
            this.tabBloodBank.Controls.Add(this.btnEditBB);
            this.tabBloodBank.Controls.Add(this.btnAddBB);
            this.tabBloodBank.Controls.Add(this.txtbbID);
            this.tabBloodBank.Controls.Add(this.txtbbBBA);
            this.tabBloodBank.Controls.Add(this.txtbbBOD);
            this.tabBloodBank.Controls.Add(this.txtbbBloodDonor);
            this.tabBloodBank.Controls.Add(this.txtbbName);
            this.tabBloodBank.Controls.Add(this.dataGridView3);
            this.tabBloodBank.Location = new System.Drawing.Point(4, 22);
            this.tabBloodBank.Name = "tabBloodBank";
            this.tabBloodBank.Padding = new System.Windows.Forms.Padding(3);
            this.tabBloodBank.Size = new System.Drawing.Size(1045, 549);
            this.tabBloodBank.TabIndex = 2;
            this.tabBloodBank.Text = "Blood Bank";
            this.tabBloodBank.UseVisualStyleBackColor = true;
            // 
            // txtpID
            // 
            this.txtpID.Enabled = false;
            this.txtpID.Location = new System.Drawing.Point(771, 36);
            this.txtpID.Name = "txtpID";
            this.txtpID.Size = new System.Drawing.Size(100, 20);
            this.txtpID.TabIndex = 6;
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(771, 331);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(251, 51);
            this.btnAddPatient.TabIndex = 7;
            this.btnAddPatient.Text = "Enter";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dID,
            this.dFirstName,
            this.dLastName,
            this.dMiddleName,
            this.dBloodGroup,
            this.dAddress,
            this.dContactNumber});
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(755, 506);
            this.dataGridView2.TabIndex = 2;
            // 
            // PatientsID
            // 
            this.PatientsID.HeaderText = "Patient ID";
            this.PatientsID.Name = "PatientsID";
            this.PatientsID.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // MiddleName
            // 
            this.MiddleName.HeaderText = "Middle Name";
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.ReadOnly = true;
            // 
            // BloodGroup
            // 
            this.BloodGroup.HeaderText = "Blood Group";
            this.BloodGroup.Name = "BloodGroup";
            this.BloodGroup.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // ContactNumber
            // 
            this.ContactNumber.HeaderText = "Contact Number";
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.ReadOnly = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bbID,
            this.bbName,
            this.bbDonor,
            this.DateOfDonation,
            this.bbAddr});
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(755, 506);
            this.dataGridView3.TabIndex = 3;
            // 
            // bbID
            // 
            this.bbID.HeaderText = "Blood Bank ID";
            this.bbID.Name = "bbID";
            this.bbID.ReadOnly = true;
            // 
            // bbName
            // 
            this.bbName.HeaderText = "Blood Bank Name";
            this.bbName.Name = "bbName";
            this.bbName.ReadOnly = true;
            // 
            // bbDonor
            // 
            this.bbDonor.HeaderText = "Blood Donor";
            this.bbDonor.Name = "bbDonor";
            this.bbDonor.ReadOnly = true;
            // 
            // DateOfDonation
            // 
            this.DateOfDonation.HeaderText = "Date Of Donation";
            this.DateOfDonation.Name = "DateOfDonation";
            this.DateOfDonation.ReadOnly = true;
            // 
            // bbAddr
            // 
            this.bbAddr.HeaderText = "Blood Bank Address";
            this.bbAddr.Name = "bbAddr";
            this.bbAddr.ReadOnly = true;
            // 
            // dID
            // 
            this.dID.HeaderText = "Donor ID";
            this.dID.Name = "dID";
            this.dID.ReadOnly = true;
            // 
            // dFirstName
            // 
            this.dFirstName.HeaderText = "First Name";
            this.dFirstName.Name = "dFirstName";
            this.dFirstName.ReadOnly = true;
            // 
            // dLastName
            // 
            this.dLastName.HeaderText = "Last Name";
            this.dLastName.Name = "dLastName";
            this.dLastName.ReadOnly = true;
            // 
            // dMiddleName
            // 
            this.dMiddleName.HeaderText = "Middle Name";
            this.dMiddleName.Name = "dMiddleName";
            this.dMiddleName.ReadOnly = true;
            // 
            // dBloodGroup
            // 
            this.dBloodGroup.HeaderText = "Blood Group";
            this.dBloodGroup.Name = "dBloodGroup";
            this.dBloodGroup.ReadOnly = true;
            // 
            // dAddress
            // 
            this.dAddress.HeaderText = "Address";
            this.dAddress.Name = "dAddress";
            this.dAddress.ReadOnly = true;
            // 
            // dContactNumber
            // 
            this.dContactNumber.HeaderText = "Contact Number";
            this.dContactNumber.Name = "dContactNumber";
            this.dContactNumber.ReadOnly = true;
            // 
            // btnAddDonor
            // 
            this.btnAddDonor.Location = new System.Drawing.Point(771, 331);
            this.btnAddDonor.Name = "btnAddDonor";
            this.btnAddDonor.Size = new System.Drawing.Size(251, 51);
            this.btnAddDonor.TabIndex = 14;
            this.btnAddDonor.Text = "Enter";
            this.btnAddDonor.UseVisualStyleBackColor = true;
            // 
            // txtdID
            // 
            this.txtdID.Enabled = false;
            this.txtdID.Location = new System.Drawing.Point(771, 36);
            this.txtdID.Name = "txtdID";
            this.txtdID.Size = new System.Drawing.Size(100, 20);
            this.txtdID.TabIndex = 13;
            // 
            // txtdAddress
            // 
            this.txtdAddress.Location = new System.Drawing.Point(770, 246);
            this.txtdAddress.Name = "txtdAddress";
            this.txtdAddress.Size = new System.Drawing.Size(252, 20);
            this.txtdAddress.TabIndex = 9;
            // 
            // txtdBloodGroup
            // 
            this.txtdBloodGroup.Location = new System.Drawing.Point(770, 199);
            this.txtdBloodGroup.Name = "txtdBloodGroup";
            this.txtdBloodGroup.Size = new System.Drawing.Size(252, 20);
            this.txtdBloodGroup.TabIndex = 10;
            // 
            // txtdMiddleName
            // 
            this.txtdMiddleName.Location = new System.Drawing.Point(770, 155);
            this.txtdMiddleName.Name = "txtdMiddleName";
            this.txtdMiddleName.Size = new System.Drawing.Size(252, 20);
            this.txtdMiddleName.TabIndex = 11;
            // 
            // txtdLastName
            // 
            this.txtdLastName.Location = new System.Drawing.Point(770, 112);
            this.txtdLastName.Name = "txtdLastName";
            this.txtdLastName.Size = new System.Drawing.Size(252, 20);
            this.txtdLastName.TabIndex = 12;
            // 
            // txtdFirstName
            // 
            this.txtdFirstName.Location = new System.Drawing.Point(770, 74);
            this.txtdFirstName.Name = "txtdFirstName";
            this.txtdFirstName.Size = new System.Drawing.Size(252, 20);
            this.txtdFirstName.TabIndex = 8;
            // 
            // txtdContactNumber
            // 
            this.txtdContactNumber.Location = new System.Drawing.Point(770, 289);
            this.txtdContactNumber.Name = "txtdContactNumber";
            this.txtdContactNumber.Size = new System.Drawing.Size(252, 20);
            this.txtdContactNumber.TabIndex = 15;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(770, 289);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(252, 20);
            this.txtContactNumber.TabIndex = 10;
            // 
            // txtbbID
            // 
            this.txtbbID.Enabled = false;
            this.txtbbID.Location = new System.Drawing.Point(771, 36);
            this.txtbbID.Name = "txtbbID";
            this.txtbbID.Size = new System.Drawing.Size(100, 20);
            this.txtbbID.TabIndex = 18;
            // 
            // txtbbBBA
            // 
            this.txtbbBBA.Location = new System.Drawing.Point(770, 199);
            this.txtbbBBA.Name = "txtbbBBA";
            this.txtbbBBA.Size = new System.Drawing.Size(252, 20);
            this.txtbbBBA.TabIndex = 15;
            // 
            // txtbbBOD
            // 
            this.txtbbBOD.Location = new System.Drawing.Point(770, 155);
            this.txtbbBOD.Name = "txtbbBOD";
            this.txtbbBOD.Size = new System.Drawing.Size(252, 20);
            this.txtbbBOD.TabIndex = 16;
            // 
            // txtbbBloodDonor
            // 
            this.txtbbBloodDonor.Location = new System.Drawing.Point(770, 112);
            this.txtbbBloodDonor.Name = "txtbbBloodDonor";
            this.txtbbBloodDonor.Size = new System.Drawing.Size(252, 20);
            this.txtbbBloodDonor.TabIndex = 17;
            // 
            // txtbbName
            // 
            this.txtbbName.Location = new System.Drawing.Point(770, 74);
            this.txtbbName.Name = "txtbbName";
            this.txtbbName.Size = new System.Drawing.Size(252, 20);
            this.txtbbName.TabIndex = 14;
            // 
            // btnAddBB
            // 
            this.btnAddBB.Location = new System.Drawing.Point(771, 256);
            this.btnAddBB.Name = "btnAddBB";
            this.btnAddBB.Size = new System.Drawing.Size(251, 51);
            this.btnAddBB.TabIndex = 19;
            this.btnAddBB.Text = "Enter";
            this.btnAddBB.UseVisualStyleBackColor = true;
            // 
            // btnEditPatient
            // 
            this.btnEditPatient.Location = new System.Drawing.Point(771, 394);
            this.btnEditPatient.Name = "btnEditPatient";
            this.btnEditPatient.Size = new System.Drawing.Size(251, 51);
            this.btnEditPatient.TabIndex = 11;
            this.btnEditPatient.Text = "Edit";
            this.btnEditPatient.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePatient
            // 
            this.btnUpdatePatient.Location = new System.Drawing.Point(771, 455);
            this.btnUpdatePatient.Name = "btnUpdatePatient";
            this.btnUpdatePatient.Size = new System.Drawing.Size(251, 51);
            this.btnUpdatePatient.TabIndex = 12;
            this.btnUpdatePatient.Text = "Update";
            this.btnUpdatePatient.UseVisualStyleBackColor = true;
            // 
            // btnUpdateDonor
            // 
            this.btnUpdateDonor.Location = new System.Drawing.Point(771, 455);
            this.btnUpdateDonor.Name = "btnUpdateDonor";
            this.btnUpdateDonor.Size = new System.Drawing.Size(251, 51);
            this.btnUpdateDonor.TabIndex = 17;
            this.btnUpdateDonor.Text = "Update";
            this.btnUpdateDonor.UseVisualStyleBackColor = true;
            // 
            // btnEditDonor
            // 
            this.btnEditDonor.Location = new System.Drawing.Point(771, 394);
            this.btnEditDonor.Name = "btnEditDonor";
            this.btnEditDonor.Size = new System.Drawing.Size(251, 51);
            this.btnEditDonor.TabIndex = 16;
            this.btnEditDonor.Text = "Edit";
            this.btnEditDonor.UseVisualStyleBackColor = true;
            // 
            // btnUpdateBB
            // 
            this.btnUpdateBB.Location = new System.Drawing.Point(771, 379);
            this.btnUpdateBB.Name = "btnUpdateBB";
            this.btnUpdateBB.Size = new System.Drawing.Size(251, 51);
            this.btnUpdateBB.TabIndex = 21;
            this.btnUpdateBB.Text = "Update";
            this.btnUpdateBB.UseVisualStyleBackColor = true;
            // 
            // btnEditBB
            // 
            this.btnEditBB.Location = new System.Drawing.Point(771, 318);
            this.btnEditBB.Name = "btnEditBB";
            this.btnEditBB.Size = new System.Drawing.Size(251, 51);
            this.btnEditBB.TabIndex = 20;
            this.btnEditBB.Text = "Edit";
            this.btnEditBB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 637);
            this.Controls.Add(this.tabs);
            this.Name = "Form1";
            this.Text = "Patients";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabs.ResumeLayout(false);
            this.tabPatients.ResumeLayout(false);
            this.tabPatients.PerformLayout();
            this.tabDonors.ResumeLayout(false);
            this.tabDonors.PerformLayout();
            this.tabBloodBank.ResumeLayout(false);
            this.tabBloodBank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtBloodGroup;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPatients;
        private System.Windows.Forms.TextBox txtpID;
        private System.Windows.Forms.TabPage tabDonors;
        private System.Windows.Forms.TabPage tabBloodBank;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BloodGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtdContactNumber;
        private System.Windows.Forms.Button btnAddDonor;
        private System.Windows.Forms.TextBox txtdID;
        private System.Windows.Forms.TextBox txtdAddress;
        private System.Windows.Forms.TextBox txtdBloodGroup;
        private System.Windows.Forms.TextBox txtdMiddleName;
        private System.Windows.Forms.TextBox txtdLastName;
        private System.Windows.Forms.TextBox txtdFirstName;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dBloodGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dContactNumber;
        private System.Windows.Forms.Button btnAddBB;
        private System.Windows.Forms.TextBox txtbbID;
        private System.Windows.Forms.TextBox txtbbBBA;
        private System.Windows.Forms.TextBox txtbbBOD;
        private System.Windows.Forms.TextBox txtbbBloodDonor;
        private System.Windows.Forms.TextBox txtbbName;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn bbID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bbName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bbDonor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfDonation;
        private System.Windows.Forms.DataGridViewTextBoxColumn bbAddr;
        private System.Windows.Forms.Button btnUpdatePatient;
        private System.Windows.Forms.Button btnEditPatient;
        private System.Windows.Forms.Button btnUpdateDonor;
        private System.Windows.Forms.Button btnEditDonor;
        private System.Windows.Forms.Button btnUpdateBB;
        private System.Windows.Forms.Button btnEditBB;
    }
}

