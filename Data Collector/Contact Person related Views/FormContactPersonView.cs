using System;
using System.IO;
using System.Windows.Forms;

namespace Janaka_Ayya_Software.Contact_Person_related_Views
{
    public partial class FormContactPersonView : Form
    {
        Form home;
        Database db;
        public FormContactPersonView(Form home)
        {
            InitializeComponent();
            this.home = home;
            db = new Database();
            this.FormClosing += new FormClosingEventHandler(FormContactPersonView_FormClosed);
        }

        private void FormContactPersonView_FormClosed(Object sender, FormClosingEventArgs e)
        {
            this.home.Show();
        }

        private void btnViewFullDetails_Click(object sender, EventArgs e)
        {
            var selectedPerson = lblNic.Text;
            if (string.IsNullOrEmpty(selectedPerson))
            {
                MessageBox.Show("Please search and select a person to view details!");
                return;
            }
            var person = new FormPersonDetailsView(this, selectedPerson);
            person.Show();
            this.Hide();

        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            var addPerson = new FormAddNewPersonDetails(this);
            addPerson.Show();
            this.Hide();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchText = txtSearch.Text;
            //if (string.IsNullOrEmpty(searchText))
            //{
            //    MessageBox.Show("Please enter valid search value");
            //    return;
            //}

            var connection = db.getContactPersonConnection();
            var cmd = connection.CreateCommand();
            if (!string.IsNullOrEmpty(searchText))
            {
                if (rbtnName.Checked)
                {
                    cmd.CommandText = @"
                                    SELECT [Name] FROM [PersonDetails] WHERE [Name] LIKE $value COLLATE NOCASE;
                                    ";
                }
                else if (rbtnArea.Checked)
                {
                    cmd.CommandText = @"
                                SELECT [Name] FROM [PersonDetails] WHERE [Area] LIKE $value COLLATE NOCASE;
                                ";
                }
                else if (rbtnDistrict.Checked)
                {
                    cmd.CommandText = @"
                                SELECT [Name] FROM [PersonDetails] WHERE [District] LIKE $value COLLATE NOCASE;
                                ";
                }
                else if (rbtnNic.Checked)
                {
                    cmd.CommandText = @"
                                SELECT [Name] FROM [PersonDetails] WHERE [Id] LIKE $value COLLATE NOCASE;
                                ";
                }
                else
                {
                    cmd.CommandText = @"
                                SELECT [Name] FROM [PersonDetails] WHERE [Telephone] LIKE $value COLLATE NOCASE;
                                ";
                }

                cmd.Parameters.AddWithValue("$value", "%" + searchText + "%");
            }
            else { 
                cmd.CommandText = @"
                            SELECT [Name] FROM [PersonDetails];
                            ";
            }
            connection.Open();
            var reader = cmd.ExecuteReader();
            lstPeople.Items.Clear();
            if (reader.HasRows)
            {   
                while (reader.Read())
                {
                    lstPeople.Items.Add(reader[0]);
                }
            }
            else
            {
                MessageBox.Show("No results found!");
            }
            lstPeople.Update();
            reader.Close();
            connection.Close();
        }

        private void lstPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            var con = db.getContactPersonConnection();

            if(lstPeople.SelectedItem is null)
            {
                return;
            }

            var selectedName = lstPeople.SelectedItem.ToString();

            var cmd = con.CreateCommand();
            cmd.CommandText = "SELECT [Id], [Name], [Address], [Birthday], [Telephone] FROM [PersonDetails] WHERE [NAME] IS $value LIMIT 1;";

            cmd.Parameters.AddWithValue("$value", selectedName);
            con.Open();
            var reader = cmd.ExecuteReader();
            reader.Read();

            lblNic.Text = reader[0].ToString();
            lblName.Text = reader[1].ToString();
            lblAdress.Text = reader[2].ToString();
            lblBday.Text = reader[3].ToString();
            lblPhone.Text = reader[4].ToString();
            reader.Close();
            con.Close();

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var searchText = txtSearch.Text;
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("All data is being exported to Excel file.");
            }

            var connection = db.getContactPersonConnection();
            var cmd = connection.CreateCommand();
            if (!string.IsNullOrEmpty(searchText))
            {
                if (rbtnName.Checked)
                {
                    cmd.CommandText = @"
                                    SELECT * FROM [PersonDetails] WHERE [Name] LIKE $value COLLATE NOCASE;
                                    ";
                }
                else if (rbtnArea.Checked)
                {
                    cmd.CommandText = @"
                                SELECT * FROM [PersonDetails] WHERE [Area] LIKE $value COLLATE NOCASE;
                                ";
                }
                else if (rbtnDistrict.Checked)
                {
                    cmd.CommandText = @"
                                SELECT * FROM [PersonDetails] WHERE [District] LIKE $value COLLATE NOCASE;
                                ";
                }
                else if (rbtnNic.Checked)
                {
                    cmd.CommandText = @"
                                SELECT * FROM [PersonDetails] WHERE [Id] LIKE $value COLLATE NOCASE;
                                ";
                }
                else
                {
                    cmd.CommandText = @"
                                SELECT * FROM [PersonDetails] WHERE [Telephone] LIKE $value COLLATE NOCASE;
                                ";
                }

                cmd.Parameters.AddWithValue("$value", "%" + searchText + "%");
            }
            else
            {
                cmd.CommandText = @"
                            SELECT * FROM [PersonDetails];
                            ";
            }
            connection.Open();
            var reader = cmd.ExecuteReader();
            var outString = "NIC,Name,Telephone,Address,Area,District,Birthday\n";
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    outString = outString + reader[0] + "," + reader[1] + "," + reader[2] + "," + reader[3] + 
                        "," + reader[4] + "," + reader[5] + "," + reader[6] + "\n";
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string sFileName = saveFileDialog.FileName;
                    File.WriteAllText(sFileName, outString);
                    MessageBox.Show("Done exporting the details!");
                }
            }
            else
            {
                MessageBox.Show("No results found!");
            }
            reader.Close();
            connection.Close();
        }
    }
}
