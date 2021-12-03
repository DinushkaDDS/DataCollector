
namespace Janaka_Ayya_Software
{
    partial class FormHomeView
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
            this.btnGeneralPublicView = new System.Windows.Forms.Button();
            this.btnContactPersonView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "General Public Data Collector";
            // 
            // btnGeneralPublicView
            // 
            this.btnGeneralPublicView.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneralPublicView.Location = new System.Drawing.Point(62, 155);
            this.btnGeneralPublicView.Margin = new System.Windows.Forms.Padding(2);
            this.btnGeneralPublicView.Name = "btnGeneralPublicView";
            this.btnGeneralPublicView.Size = new System.Drawing.Size(219, 126);
            this.btnGeneralPublicView.TabIndex = 2;
            this.btnGeneralPublicView.Text = "General Public Details";
            this.btnGeneralPublicView.UseVisualStyleBackColor = true;
            this.btnGeneralPublicView.Click += new System.EventHandler(this.btnGeneralPublicView_Click);
            // 
            // btnContactPersonView
            // 
            this.btnContactPersonView.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContactPersonView.Location = new System.Drawing.Point(325, 155);
            this.btnContactPersonView.Margin = new System.Windows.Forms.Padding(2);
            this.btnContactPersonView.Name = "btnContactPersonView";
            this.btnContactPersonView.Size = new System.Drawing.Size(219, 126);
            this.btnContactPersonView.TabIndex = 3;
            this.btnContactPersonView.Text = "Contact Person Details";
            this.btnContactPersonView.UseVisualStyleBackColor = true;
            this.btnContactPersonView.Click += new System.EventHandler(this.btnContactPersonView_Click);
            // 
            // FormHomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnContactPersonView);
            this.Controls.Add(this.btnGeneralPublicView);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHomeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGeneralPublicView;
        private System.Windows.Forms.Button btnContactPersonView;
    }
}

