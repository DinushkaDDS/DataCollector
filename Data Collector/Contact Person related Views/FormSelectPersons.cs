using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Janaka_Ayya_Software.Contact_Person_related_Views
{
    public partial class FormSelectPersons : Form
    {

        private Form parent;
        private bool isLeaderSelect;
        Database db;
        public string selectedVals { get; set; }
        private List<string> contactIds = new List<string>();
        private object leaderId = null;
        private string personId;
        private SqliteConnection connection;
        private volatile bool  isSearching;

        public FormSelectPersons(Form parent, bool isLeaderSelect, string personId, string tempLeader, List<string> tempContacts)
        {
            InitializeComponent();
            this.parent = parent;
            db = new Database();
            this.personId = personId;
            this.isLeaderSelect = isLeaderSelect;

            leaderId = tempLeader;
            contactIds = tempContacts;

            this.connection = db.getContactPersonConnection();
            connection.Open();
            if (string.IsNullOrEmpty(personId))
            {
                return;
            }
            var cmd = connection.CreateCommand();
            cmd.CommandText = @"
                                SELECT [Leader] FROM [Relations] WHERE [Subordinate] IS $value LIMIT 1;
                                ";
            cmd.Parameters.AddWithValue("$value", personId);
            this.leaderId = cmd.ExecuteScalar();

            cmd = connection.CreateCommand();
            cmd.CommandText = @"
                                SELECT [Subordinate] FROM [Relations] WHERE [Leader] IS $value;
                                ";
            cmd.Parameters.AddWithValue("$value", personId);
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    contactIds.Add(reader[0].ToString());
                }
            }
            reader.Close();
            connection.Close();
        }

        private void clstboxPersons_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (clstboxPersons.CheckedItems.Count >= 1 && isLeaderSelect && e.NewValue == CheckState.Checked)
            {
                MessageBox.Show("You can only check one item");
                clstboxPersons.SetItemCheckState(e.Index, CheckState.Unchecked);
                e.NewValue = CheckState.Unchecked;
                return;
            }
            if (isSearching)
            {
                return;
            }

            if (isLeaderSelect)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    leaderId = lblNic.Text.ToString();
                }
                else
                {
                    leaderId = null;
                }
            }
            else
            {
                if (e.NewValue == CheckState.Checked)
                {
                    contactIds.Add(lblNic.Text.ToString());
                }
                else
                {
                    contactIds.Remove(lblNic.Text.ToString());
                }
            }

        }

        private void doDBActions()
        {
            connection.Open();
            var cmd = connection.CreateCommand();

            //THINK TWICE BEFORE REMOVE --> ESSENTIAL CHECKING
            if (string.IsNullOrEmpty(personId))
            {
                return;
            }

            if (isLeaderSelect)
            {
                cmd.CommandText = @"REPLACE INTO [Relations]
                                       ([Leader]
                                       ,[Subordinate])
                                 VALUES
                                       ($leaderId
                                       ,$subordinateId);";
                cmd.Parameters.AddWithValue("$leaderId", lblNic.Text.ToString());
                cmd.Parameters.AddWithValue("$subordinateId", personId);
                cmd.ExecuteNonQuery();
            }
            else
            {
                cmd.CommandText = @"DELETE FROM [Relations]
                                       WHERE [Leader] IS $leaderId;";
                cmd.Parameters.AddWithValue("leaderId", personId);
                cmd.ExecuteNonQuery();
                

                foreach (var contactId in contactIds)
                {
                    cmd = connection.CreateCommand();
                    cmd.CommandText = @"INSERT INTO [Relations]
                                       ([Leader]
                                       ,[Subordinate])
                                 VALUES
                                       ($leaderId
                                       ,$subordinateId);";
                    cmd.Parameters.AddWithValue("$leaderId", personId);
                    cmd.Parameters.AddWithValue("$subordinateId", contactId);
                    cmd.ExecuteNonQuery();
                }
            }
            connection.Close();
        }


        private void btnDone_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            foreach (var i in clstboxPersons.CheckedItems)
            {
                if (string.IsNullOrEmpty(this.selectedVals))
                {
                    selectedVals = i.ToString().Split(':')[1].Trim();
                }
                else
                {
                    this.selectedVals = this.selectedVals + "; " + i.ToString().Split(':')[1].Trim();
                }
            }
            doDBActions();
            this.Close();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            isSearching = true;
            connection.Open();
            var searchText = txtSearch.Text;
            //if (string.IsNullOrEmpty(searchText))
            //{
            //    MessageBox.Show("Please enter valid search value");
            //    return;
            //}

            var cmd = connection.CreateCommand();
            if (!string.IsNullOrEmpty(searchText))
            {
                if (rbtnName.Checked)
                {
                    cmd.CommandText = @"
                                SELECT [Name],[Id] FROM [PersonDetails] WHERE [Name] LIKE $value COLLATE NOCASE;
                                ";
                }
                else if (rbtnArea.Checked)
                {
                    cmd.CommandText = @"
                            SELECT [Name],[Id] FROM [PersonDetails] WHERE [Area] LIKE $value COLLATE NOCASE;
                            ";
                }
                else if (rbtnDistrict.Checked)
                {
                    cmd.CommandText = @"
                            SELECT [Name],[Id] FROM [PersonDetails] WHERE [District] LIKE $value COLLATE NOCASE;
                            ";
                }
                else if (rbtnNic.Checked)
                {
                    cmd.CommandText = @"
                            SELECT [Name],[Id] FROM [PersonDetails] WHERE [Id] LIKE $value COLLATE NOCASE;
                            ";
                }
                else
                {
                    cmd.CommandText = @"
                            SELECT [Name],[Id] FROM [PersonDetails] WHERE [Telephone] LIKE $value COLLATE NOCASE;
                            ";
                }
                cmd.Parameters.AddWithValue("$value", "%" + searchText + "%");
            }
            else
            {
                cmd.CommandText = @"
                            SELECT [Name],[Id] FROM [PersonDetails];
                            ";
            }
            

            
            var reader = cmd.ExecuteReader();
            clstboxPersons.Items.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (!string.IsNullOrEmpty(personId) && (string)reader[1] == personId)
                    {
                        continue;
                    }
                    if (isLeaderSelect)
                    {
                        if (!string.IsNullOrEmpty((string)leaderId) && (string)leaderId == (string)reader[1])
                        {
                            clstboxPersons.Items.Add(reader[0] + " : " + reader[1]);
                            clstboxPersons.SetItemChecked(clstboxPersons.Items.Count - 1, true);

                        }
                        else if (contactIds == null || !contactIds.Contains(reader[1]))
                        {
                            clstboxPersons.Items.Add(reader[0] + " : " + reader[1]);
                        }
                    }
                    else
                    {
                        if (contactIds != null && contactIds.Contains(reader[1]))
                        {
                            clstboxPersons.Items.Add(reader[0] + " : " + reader[1]);
                            clstboxPersons.SetItemChecked(clstboxPersons.Items.Count - 1, true);
                        }
                        else if (string.IsNullOrEmpty((string)leaderId) || (string)leaderId != (string)reader[1])
                        {
                            clstboxPersons.Items.Add(reader[0] + " : " + reader[1]);
                        }
                    }
                }
            }
            if (clstboxPersons.Items.Count == 0)
            {
                MessageBox.Show("No results found!");
            }
            clstboxPersons.Update();
            reader.Close();
            connection.Close();
            isSearching = false;
        }

        private void clstboxPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clstboxPersons.SelectedItem is null)
            {
                return;
            }
            var selectedName = clstboxPersons.SelectedItem.ToString().Split(':')[1].Trim();
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT [Id], [Name], [Address], [Birthday], [Telephone] FROM [PersonDetails] WHERE [Id] IS $value LIMIT 1;";

            cmd.Parameters.AddWithValue("$value", selectedName);
            var reader = cmd.ExecuteReader();
            reader.Read();

            lblNic.Text = reader[0].ToString();
            lblName.Text = reader[1].ToString();
            lblAddress.Text = reader[2].ToString();
            lblBday.Text = reader[3].ToString();
            lblPhone.Text = reader[4].ToString();
            reader.Close();
            connection.Close();
        }
    }
}
