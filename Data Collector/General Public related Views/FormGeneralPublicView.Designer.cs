
namespace Janaka_Ayya_Software
{
    partial class FormGeneralPublicView
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstPeople = new System.Windows.Forms.ListBox();
            this.rbtnName = new System.Windows.Forms.RadioButton();
            this.rbtnNic = new System.Windows.Forms.RadioButton();
            this.rbtnPhone = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnViewFullDetails = new System.Windows.Forms.Button();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblBday = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblNic = new System.Windows.Forms.Label();
            this.rbtnDistrict = new System.Windows.Forms.RadioButton();
            this.rbtnArea = new System.Windows.Forms.RadioButton();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "General Public Details";
            // 
            // lstPeople
            // 
            this.lstPeople.FormattingEnabled = true;
            this.lstPeople.ItemHeight = 16;
            this.lstPeople.Location = new System.Drawing.Point(45, 128);
            this.lstPeople.Name = "lstPeople";
            this.lstPeople.Size = new System.Drawing.Size(356, 388);
            this.lstPeople.TabIndex = 1;
            this.lstPeople.SelectedIndexChanged += new System.EventHandler(this.lstPeople_SelectedIndexChanged);
            // 
            // rbtnName
            // 
            this.rbtnName.AutoSize = true;
            this.rbtnName.Checked = true;
            this.rbtnName.Location = new System.Drawing.Point(54, 75);
            this.rbtnName.Name = "rbtnName";
            this.rbtnName.Size = new System.Drawing.Size(86, 21);
            this.rbtnName.TabIndex = 2;
            this.rbtnName.TabStop = true;
            this.rbtnName.Text = "By Name";
            this.rbtnName.UseVisualStyleBackColor = true;
            // 
            // rbtnNic
            // 
            this.rbtnNic.AutoSize = true;
            this.rbtnNic.Location = new System.Drawing.Point(163, 75);
            this.rbtnNic.Name = "rbtnNic";
            this.rbtnNic.Size = new System.Drawing.Size(71, 21);
            this.rbtnNic.TabIndex = 3;
            this.rbtnNic.Text = "By NIC";
            this.rbtnNic.UseVisualStyleBackColor = true;
            // 
            // rbtnPhone
            // 
            this.rbtnPhone.AutoSize = true;
            this.rbtnPhone.Location = new System.Drawing.Point(257, 75);
            this.rbtnPhone.Name = "rbtnPhone";
            this.rbtnPhone.Size = new System.Drawing.Size(144, 21);
            this.rbtnPhone.TabIndex = 4;
            this.rbtnPhone.Text = "By Phone Number";
            this.rbtnPhone.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(624, 73);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(217, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(901, 68);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 33);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Birthday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Phone No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "NIC";
            // 
            // btnViewFullDetails
            // 
            this.btnViewFullDetails.Location = new System.Drawing.Point(637, 316);
            this.btnViewFullDetails.Name = "btnViewFullDetails";
            this.btnViewFullDetails.Size = new System.Drawing.Size(140, 50);
            this.btnViewFullDetails.TabIndex = 12;
            this.btnViewFullDetails.Text = "View Full Details";
            this.btnViewFullDetails.UseVisualStyleBackColor = true;
            this.btnViewFullDetails.Click += new System.EventHandler(this.btnViewFullDetails_Click);
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Location = new System.Drawing.Point(546, 387);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(326, 68);
            this.btnAddNewPerson.TabIndex = 13;
            this.btnAddNewPerson.Text = "Add New Person Details";
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(605, 143);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 17);
            this.lblName.TabIndex = 15;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(605, 178);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(0, 17);
            this.lblAdress.TabIndex = 16;
            // 
            // lblBday
            // 
            this.lblBday.AutoSize = true;
            this.lblBday.Location = new System.Drawing.Point(605, 212);
            this.lblBday.Name = "lblBday";
            this.lblBday.Size = new System.Drawing.Size(0, 17);
            this.lblBday.TabIndex = 17;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(605, 249);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(0, 17);
            this.lblPhone.TabIndex = 18;
            // 
            // lblNic
            // 
            this.lblNic.AutoSize = true;
            this.lblNic.Location = new System.Drawing.Point(605, 280);
            this.lblNic.Name = "lblNic";
            this.lblNic.Size = new System.Drawing.Size(0, 17);
            this.lblNic.TabIndex = 19;
            // 
            // rbtnDistrict
            // 
            this.rbtnDistrict.AutoSize = true;
            this.rbtnDistrict.Location = new System.Drawing.Point(407, 76);
            this.rbtnDistrict.Name = "rbtnDistrict";
            this.rbtnDistrict.Size = new System.Drawing.Size(92, 21);
            this.rbtnDistrict.TabIndex = 20;
            this.rbtnDistrict.TabStop = true;
            this.rbtnDistrict.Text = "By District";
            this.rbtnDistrict.UseVisualStyleBackColor = true;
            // 
            // rbtnArea
            // 
            this.rbtnArea.AutoSize = true;
            this.rbtnArea.Location = new System.Drawing.Point(526, 75);
            this.rbtnArea.Name = "rbtnArea";
            this.rbtnArea.Size = new System.Drawing.Size(79, 21);
            this.rbtnArea.TabIndex = 21;
            this.rbtnArea.TabStop = true;
            this.rbtnArea.Text = "By Area";
            this.rbtnArea.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(843, 475);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(190, 52);
            this.btnPrint.TabIndex = 22;
            this.btnPrint.Text = "Print details";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FormGeneralPublicView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 556);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.rbtnArea);
            this.Controls.Add(this.rbtnDistrict);
            this.Controls.Add(this.lblNic);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblBday);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAddNewPerson);
            this.Controls.Add(this.btnViewFullDetails);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.rbtnPhone);
            this.Controls.Add(this.rbtnNic);
            this.Controls.Add(this.rbtnName);
            this.Controls.Add(this.lstPeople);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGeneralPublicView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGeneralPublicView";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstPeople;
        private System.Windows.Forms.RadioButton rbtnName;
        private System.Windows.Forms.RadioButton rbtnNic;
        private System.Windows.Forms.RadioButton rbtnPhone;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnViewFullDetails;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblBday;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblNic;
        private System.Windows.Forms.RadioButton rbtnDistrict;
        private System.Windows.Forms.RadioButton rbtnArea;
        private System.Windows.Forms.Button btnPrint;
    }
}