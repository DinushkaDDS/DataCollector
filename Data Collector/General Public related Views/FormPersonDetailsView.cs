using Janaka_Ayya_Software.General_Public_related_Views;
using System;
using System.Windows.Forms;

namespace Janaka_Ayya_Software
{
    public partial class FormPersonDetailsView : Form
    {

        Form parent;
        string selectedPersonId;
        Database db;

        public FormPersonDetailsView(Form parent, string selectedPerson)
        {
            InitializeComponent();
            this.parent = parent;
            this.selectedPersonId = selectedPerson;
            db = new Database();
            var con = db.getGeneralPublicConnection();
            var cmd = con.CreateCommand();
            cmd.CommandText = "SELECT [Id], [Name], [Address], [Birthday], [Telephone] FROM [UserDetails] WHERE [Id] IS $value;";

            cmd.Parameters.AddWithValue("$value", selectedPerson);
            con.Open();
            var reader = cmd.ExecuteReader();
            reader.Read();
            lblNic.Text = reader[0].ToString();
            lblName.Text = reader[1].ToString();
            lblAddress.Text = reader[2].ToString();
            lblBday.Text = reader[3].ToString();
            lblPhone.Text = reader[4].ToString();
            reader.Close();
            con.Close();

            refreshGrid();

            this.FormClosing += new FormClosingEventHandler(FormPersonDetailsView_FormClosed);
        }

        private void FormPersonDetailsView_FormClosed(Object sender, FormClosingEventArgs e)
        {
            this.parent.Show();
        }

        public void refreshGrid()
        {
            this.dataGrid.Rows.Clear();
            var con = db.getGeneralPublicConnection();
            var cmd = con.CreateCommand();
            cmd.CommandText = "SELECT [Description], [Comments] FROM [UserDescriptions] WHERE [Id] IS $value;";
            cmd.Parameters.AddWithValue("$value", selectedPersonId);
            
            con.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (string.IsNullOrEmpty(reader[1].ToString()))
                {

                }
                this.dataGrid.Rows.Add(reader[0], reader[1]);
            }
            reader.Close();
            con.Close();
        }

        private void btnAddDetails_Click(object sender, EventArgs e)
        {
            Form addDetails = new FormAddNewVisitDetailsView(this, selectedPersonId, lblName.Text);
            addDetails.Show();
            this.Hide();
        }
    }
}
