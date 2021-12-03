
namespace Janaka_Ayya_Software.Contact_Person_related_Views
{
    partial class FormSelectPersons
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
            this.clstboxPersons = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
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
            this.rbtnArea = new System.Windows.Forms.RadioButton();
            this.rbtnDistrict = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rbtnPhone = new System.Windows.Forms.RadioButton();
            this.rbtnNic = new System.Windows.Forms.RadioButton();
            this.rbtnName = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // clstboxPersons
            // 
            this.clstboxPersons.CheckOnClick = true;
            this.clstboxPersons.FormattingEnabled = true;
            this.clstboxPersons.Location = new System.Drawing.Point(52, 117);
            this.clstboxPersons.Name = "clstboxPersons";
            this.clstboxPersons.Size = new System.Drawing.Size(417, 242);
            this.clstboxPersons.TabIndex = 0;
            this.clstboxPersons.SelectedIndexChanged += new System.EventHandler(this.clstboxPersons_SelectedIndexChanged);
            this.clstboxPersons.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clstboxPersons_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 102;
            this.label1.Text = "Select People to add";
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(398, 403);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(247, 47);
            this.btnDone.TabIndex = 103;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(545, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 108;
            this.label6.Text = "NIC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 107;
            this.label5.Text = "Phone No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(545, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 106;
            this.label4.Text = "Birthday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 105;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 104;
            this.label2.Text = "Name";
            // 
            // lblNic
            // 
            this.lblNic.AutoSize = true;
            this.lblNic.Location = new System.Drawing.Point(622, 286);
            this.lblNic.Name = "lblNic";
            this.lblNic.Size = new System.Drawing.Size(0, 17);
            this.lblNic.TabIndex = 113;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(622, 254);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(0, 17);
            this.lblPhone.TabIndex = 112;
            // 
            // lblBday
            // 
            this.lblBday.AutoSize = true;
            this.lblBday.Location = new System.Drawing.Point(622, 217);
            this.lblBday.Name = "lblBday";
            this.lblBday.Size = new System.Drawing.Size(0, 17);
            this.lblBday.TabIndex = 111;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(622, 183);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(0, 17);
            this.lblAddress.TabIndex = 110;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(622, 149);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 17);
            this.lblName.TabIndex = 109;
            // 
            // rbtnArea
            // 
            this.rbtnArea.AutoSize = true;
            this.rbtnArea.Location = new System.Drawing.Point(496, 67);
            this.rbtnArea.Name = "rbtnArea";
            this.rbtnArea.Size = new System.Drawing.Size(79, 21);
            this.rbtnArea.TabIndex = 120;
            this.rbtnArea.TabStop = true;
            this.rbtnArea.Text = "By Area";
            this.rbtnArea.UseVisualStyleBackColor = true;
            // 
            // rbtnDistrict
            // 
            this.rbtnDistrict.AutoSize = true;
            this.rbtnDistrict.Location = new System.Drawing.Point(377, 68);
            this.rbtnDistrict.Name = "rbtnDistrict";
            this.rbtnDistrict.Size = new System.Drawing.Size(92, 21);
            this.rbtnDistrict.TabIndex = 119;
            this.rbtnDistrict.TabStop = true;
            this.rbtnDistrict.Text = "By District";
            this.rbtnDistrict.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(871, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 33);
            this.btnSearch.TabIndex = 116;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(594, 65);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(217, 22);
            this.txtSearch.TabIndex = 114;
            // 
            // rbtnPhone
            // 
            this.rbtnPhone.AutoSize = true;
            this.rbtnPhone.Location = new System.Drawing.Point(227, 67);
            this.rbtnPhone.Name = "rbtnPhone";
            this.rbtnPhone.Size = new System.Drawing.Size(144, 21);
            this.rbtnPhone.TabIndex = 118;
            this.rbtnPhone.Text = "By Phone Number";
            this.rbtnPhone.UseVisualStyleBackColor = true;
            // 
            // rbtnNic
            // 
            this.rbtnNic.AutoSize = true;
            this.rbtnNic.Location = new System.Drawing.Point(133, 67);
            this.rbtnNic.Name = "rbtnNic";
            this.rbtnNic.Size = new System.Drawing.Size(71, 21);
            this.rbtnNic.TabIndex = 117;
            this.rbtnNic.Text = "By NIC";
            this.rbtnNic.UseVisualStyleBackColor = true;
            // 
            // rbtnName
            // 
            this.rbtnName.AutoSize = true;
            this.rbtnName.Checked = true;
            this.rbtnName.Location = new System.Drawing.Point(24, 67);
            this.rbtnName.Name = "rbtnName";
            this.rbtnName.Size = new System.Drawing.Size(86, 21);
            this.rbtnName.TabIndex = 115;
            this.rbtnName.TabStop = true;
            this.rbtnName.Text = "By Name";
            this.rbtnName.UseVisualStyleBackColor = true;
            // 
            // FormSelectPersons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 489);
            this.Controls.Add(this.rbtnArea);
            this.Controls.Add(this.rbtnDistrict);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.rbtnPhone);
            this.Controls.Add(this.rbtnNic);
            this.Controls.Add(this.rbtnName);
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
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clstboxPersons);
            this.Name = "FormSelectPersons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSelectPersons";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clstboxPersons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDone;
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
        private System.Windows.Forms.RadioButton rbtnArea;
        private System.Windows.Forms.RadioButton rbtnDistrict;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rbtnPhone;
        private System.Windows.Forms.RadioButton rbtnNic;
        private System.Windows.Forms.RadioButton rbtnName;
    }
}