
namespace Janaka_Ayya_Software.Contact_Person_related_Views
{
    partial class FormPersonDetailsView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Nic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeaderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddSubordinateDetails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNic = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblBday = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblLeaderName = new System.Windows.Forms.Label();
            this.btnAddLeader = new System.Windows.Forms.Button();
            this.lblLeaderId = new System.Windows.Forms.Label();
            this.lblLeaderAddress = new System.Windows.Forms.Label();
            this.lblLeaderTelephone = new System.Windows.Forms.Label();
            this.btnDeleteProfile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid.ColumnHeadersHeight = 29;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nic,
            this.LeaderName,
            this.Address,
            this.Telephone});
            this.dataGrid.Location = new System.Drawing.Point(90, 270);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.RowTemplate.ReadOnly = true;
            this.dataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.Size = new System.Drawing.Size(764, 214);
            this.dataGrid.TabIndex = 33;
            this.dataGrid.TabStop = false;
            // 
            // Nic
            // 
            this.Nic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Nic.DefaultCellStyle = dataGridViewCellStyle1;
            this.Nic.HeaderText = "Nic";
            this.Nic.MinimumWidth = 200;
            this.Nic.Name = "Nic";
            this.Nic.ReadOnly = true;
            this.Nic.Width = 200;
            // 
            // LeaderName
            // 
            this.LeaderName.HeaderText = "Name";
            this.LeaderName.MinimumWidth = 6;
            this.LeaderName.Name = "LeaderName";
            this.LeaderName.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Telephone
            // 
            this.Telephone.HeaderText = "Telephone";
            this.Telephone.MinimumWidth = 6;
            this.Telephone.Name = "Telephone";
            this.Telephone.ReadOnly = true;
            // 
            // btnAddSubordinateDetails
            // 
            this.btnAddSubordinateDetails.Location = new System.Drawing.Point(688, 49);
            this.btnAddSubordinateDetails.Name = "btnAddSubordinateDetails";
            this.btnAddSubordinateDetails.Size = new System.Drawing.Size(166, 42);
            this.btnAddSubordinateDetails.TabIndex = 32;
            this.btnAddSubordinateDetails.Text = "Change Subordinates";
            this.btnAddSubordinateDetails.UseVisualStyleBackColor = true;
            this.btnAddSubordinateDetails.Click += new System.EventHandler(this.btnAddSubordinateDetails_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Subordinate Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "NIC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Phone No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Birthday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Name";
            // 
            // lblNic
            // 
            this.lblNic.AutoSize = true;
            this.lblNic.Location = new System.Drawing.Point(218, 177);
            this.lblNic.Name = "lblNic";
            this.lblNic.Size = new System.Drawing.Size(0, 17);
            this.lblNic.TabIndex = 38;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(218, 148);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(0, 17);
            this.lblPhone.TabIndex = 37;
            // 
            // lblBday
            // 
            this.lblBday.AutoSize = true;
            this.lblBday.Location = new System.Drawing.Point(218, 117);
            this.lblBday.Name = "lblBday";
            this.lblBday.Size = new System.Drawing.Size(0, 17);
            this.lblBday.TabIndex = 36;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(218, 83);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(0, 17);
            this.lblAddress.TabIndex = 35;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(218, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 17);
            this.lblName.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "Leader Details";
            // 
            // lblLeaderName
            // 
            this.lblLeaderName.AutoSize = true;
            this.lblLeaderName.Location = new System.Drawing.Point(220, 217);
            this.lblLeaderName.Name = "lblLeaderName";
            this.lblLeaderName.Size = new System.Drawing.Size(0, 17);
            this.lblLeaderName.TabIndex = 40;
            // 
            // btnAddLeader
            // 
            this.btnAddLeader.Location = new System.Drawing.Point(688, 117);
            this.btnAddLeader.Name = "btnAddLeader";
            this.btnAddLeader.Size = new System.Drawing.Size(166, 37);
            this.btnAddLeader.TabIndex = 41;
            this.btnAddLeader.Text = "Change Leader";
            this.btnAddLeader.UseVisualStyleBackColor = true;
            this.btnAddLeader.Click += new System.EventHandler(this.btnAddLeader_Click);
            // 
            // lblLeaderId
            // 
            this.lblLeaderId.AutoSize = true;
            this.lblLeaderId.Location = new System.Drawing.Point(383, 217);
            this.lblLeaderId.Name = "lblLeaderId";
            this.lblLeaderId.Size = new System.Drawing.Size(0, 17);
            this.lblLeaderId.TabIndex = 42;
            // 
            // lblLeaderAddress
            // 
            this.lblLeaderAddress.AutoSize = true;
            this.lblLeaderAddress.Location = new System.Drawing.Point(549, 217);
            this.lblLeaderAddress.Name = "lblLeaderAddress";
            this.lblLeaderAddress.Size = new System.Drawing.Size(0, 17);
            this.lblLeaderAddress.TabIndex = 43;
            // 
            // lblLeaderTelephone
            // 
            this.lblLeaderTelephone.AutoSize = true;
            this.lblLeaderTelephone.Location = new System.Drawing.Point(702, 217);
            this.lblLeaderTelephone.Name = "lblLeaderTelephone";
            this.lblLeaderTelephone.Size = new System.Drawing.Size(0, 17);
            this.lblLeaderTelephone.TabIndex = 44;
            // 
            // btnDeleteProfile
            // 
            this.btnDeleteProfile.Location = new System.Drawing.Point(311, 491);
            this.btnDeleteProfile.Name = "btnDeleteProfile";
            this.btnDeleteProfile.Size = new System.Drawing.Size(351, 36);
            this.btnDeleteProfile.TabIndex = 47;
            this.btnDeleteProfile.Text = "Delete Profile";
            this.btnDeleteProfile.UseVisualStyleBackColor = true;
            this.btnDeleteProfile.Click += new System.EventHandler(this.btnDeleteProfile_Click);
            // 
            // FormPersonDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 565);
            this.Controls.Add(this.btnDeleteProfile);
            this.Controls.Add(this.lblLeaderTelephone);
            this.Controls.Add(this.lblLeaderAddress);
            this.Controls.Add(this.lblLeaderId);
            this.Controls.Add(this.btnAddLeader);
            this.Controls.Add(this.lblLeaderName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btnAddSubordinateDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNic);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblBday);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Name = "FormPersonDetailsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPersonDetailsView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnAddSubordinateDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNic;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblBday;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblLeaderName;
        private System.Windows.Forms.Button btnAddLeader;
        private System.Windows.Forms.Label lblLeaderId;
        private System.Windows.Forms.Label lblLeaderAddress;
        private System.Windows.Forms.Label lblLeaderTelephone;
        private System.Windows.Forms.Button btnDeleteProfile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nic;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeaderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
    }
}