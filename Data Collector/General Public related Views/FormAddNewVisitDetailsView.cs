using System;
using System.Windows.Forms;

namespace Janaka_Ayya_Software.General_Public_related_Views
{
    public partial class FormAddNewVisitDetailsView : Form
    {

        FormPersonDetailsView parent;
        string personId;
        Database db;
        public FormAddNewVisitDetailsView(FormPersonDetailsView parent, string personId, string personName)
        {
            InitializeComponent();
            this.parent = parent;
            this.personId = personId;
            db = new Database();
            this.lblName.Text = personName;
            this.FormClosing += new FormClosingEventHandler(FormAddNewVisitDetailsView_FormClosed);
        }

        private void FormAddNewVisitDetailsView_FormClosed(Object sender, FormClosingEventArgs e)
        {
            this.parent.refreshGrid();
            this.parent.Show();
        }

        private void btnAddDetails_Click(object sender, EventArgs e)
        {
            var con = db.getGeneralPublicConnection();

            var cmd = con.CreateCommand();
            cmd.CommandText = @"
                        INSERT INTO [UserDescriptions]
                                   ([Id]
                                   ,[Description]
                                   ,[Solved]
                                   ,[Comments])
                             VALUES
                                   ($id
                                   ,$description
                                   ,$solved
                                   ,$comments);";

            if(string.IsNullOrEmpty(txtAdvice.Text.ToString()) || string.IsNullOrEmpty(txtReason.Text.ToString()))
            {
                MessageBox.Show("Please enter values for all the fields.");
                return;
            }

            cmd.Parameters.AddWithValue("$id", personId);
            cmd.Parameters.AddWithValue("$description", txtReason.Text);
            cmd.Parameters.AddWithValue("$solved", cboxSolved.Checked);
            cmd.Parameters.AddWithValue("$comments", txtAdvice.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            this.Close();
        }
    }
}
