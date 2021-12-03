
namespace Janaka_Ayya_Software.General_Public_related_Views
{
    partial class FormAddNewVisitDetailsView
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddDetails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.txtAdvice = new System.Windows.Forms.TextBox();
            this.cboxSolved = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Name";
            // 
            // btnAddDetails
            // 
            this.btnAddDetails.Location = new System.Drawing.Point(320, 358);
            this.btnAddDetails.Name = "btnAddDetails";
            this.btnAddDetails.Size = new System.Drawing.Size(132, 36);
            this.btnAddDetails.TabIndex = 22;
            this.btnAddDetails.Text = "Add Details";
            this.btnAddDetails.UseVisualStyleBackColor = true;
            this.btnAddDetails.Click += new System.EventHandler(this.btnAddDetails_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Reason for Visit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Advise Given";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(223, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 17);
            this.lblName.TabIndex = 25;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(226, 105);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(472, 22);
            this.txtReason.TabIndex = 26;
            // 
            // txtAdvice
            // 
            this.txtAdvice.Location = new System.Drawing.Point(226, 205);
            this.txtAdvice.Name = "txtAdvice";
            this.txtAdvice.Size = new System.Drawing.Size(472, 22);
            this.txtAdvice.TabIndex = 27;
            // 
            // cboxSolved
            // 
            this.cboxSolved.AutoSize = true;
            this.cboxSolved.Location = new System.Drawing.Point(52, 280);
            this.cboxSolved.Name = "cboxSolved";
            this.cboxSolved.Size = new System.Drawing.Size(73, 21);
            this.cboxSolved.TabIndex = 28;
            this.cboxSolved.Text = "Solved";
            this.cboxSolved.UseVisualStyleBackColor = true;
            // 
            // FormAddNewVisitDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboxSolved);
            this.Controls.Add(this.txtAdvice);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddDetails);
            this.Controls.Add(this.label2);
            this.Name = "FormAddNewVisitDetailsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddNewVisitDetailsView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.TextBox txtAdvice;
        private System.Windows.Forms.CheckBox cboxSolved;
    }
}