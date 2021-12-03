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
            var con = db.getContactPersonConnection();
            var cmd = con.CreateCommand();
            cmd.CommandText = "SELECT [Id], [Name], [Address], [Birthday], [Telephone] FROM [PersonDetails] WHERE [Id] IS $value;";

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


            cmd = con.CreateCommand();
            cmd.CommandText = @"
            SELECT [Id], [Name], [Address], [Telephone] FROM [PersonDetails]  
						JOIN [Relations] 
            ON [PersonDetails].[Id]=[Relations].[Leader] WHERE [Relations].[Subordinate] IS $Id LIMIT 1;
            ";
            
            cmd.Parameters.AddWithValue("$Id", selectedPerson);
            con.Open();
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                lblLeaderId.Text = reader[0].ToString();
                lblLeaderName.Text = reader[1].ToString();
                lblLeaderAddress.Text = reader[2].ToString();
                lblLeaderTelephone.Text = reader[3].ToString();
            }
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
            var con = db.getContactPersonConnection();
            var cmd = con.CreateCommand();
            cmd.CommandText = @"
                        SELECT [Id], [Name], [Address], [Telephone] FROM [PersonDetails]  
						            JOIN [Relations] 
                        ON [PersonDetails].[Id]=[Relations].[Subordinate] WHERE [Relations].[Leader] IS $Id;
                        ";
            cmd.Parameters.AddWithValue("$Id", selectedPersonId);

            con.Open();
            var reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                dataGrid.Rows.Clear();
                while (reader.Read())
                {
                    this.dataGrid.Rows.Add(reader[0], reader[1], reader[2], reader[3]);
                }
                dataGrid.Update();
            }
            reader.Close();
            con.Close();
        }

        private void btnAddSubordinateDetails_Click(object sender, EventArgs e)
        {
            var contactIds = new List<string>();
            string leaderId = null;
            if (!string.IsNullOrEmpty(lblLeaderId.Text.ToString()))
            {
               leaderId = lblLeaderId.Text.ToString().Trim();
            }
            contactIds.Add(lblNic.Text.ToString().Trim());
            foreach (DataGridViewRow i in dataGrid.Rows)
            {
                contactIds.Add(i.Cells[0].Value.ToString().Trim());
            }
            using (var addSubordinates = new FormSelectPersons(this, false, lblNic.Text.ToString(), leaderId, contactIds))
            {
                var result = addSubordinates.ShowDialog();
                if (result == DialogResult.OK)
                {
                    refreshGrid();
                    return;
                }
            }
            refreshGrid();
        }

        private void btnAddLeader_Click(object sender, EventArgs e)
        {
            var contactIds = new List<string>();

            string leaderId = null;
            contactIds.Add(lblNic.Text.ToString().Trim());
            foreach (DataGridViewRow i in dataGrid.Rows)
            {
                contactIds.Add(i.Cells[0].Value.ToString().Trim());
            }

            using (var changeLeader = new FormSelectPersons(this, true, selectedPersonId, leaderId, contactIds))
            {
                var result = changeLeader.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string dataString = changeLeader.selectedVals;
                    if (string.IsNullOrEmpty(dataString))
                    {
                        lblLeaderAddress.Text = "";
                        lblLeaderId.Text = "";
                        lblLeaderName.Text = "";
                        lblLeaderTelephone.Text = "";
                        return;
                    }
                    else
                    {
                        var con = db.getContactPersonConnection();
                        var cmd = con.CreateCommand();
                        cmd.CommandText = @"
                        SELECT [Id], [Name], [Address], [Telephone] FROM [PersonDetails]  
						            JOIN [Relations] 
                        ON [PersonDetails].[Id]=[Relations].[Leader] WHERE [Relations].[Subordinate] IS $Id LIMIT 1;
                        ";

                        cmd.Parameters.AddWithValue("$Id", selectedPersonId);
                        con.Open();
                        var reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            reader.Read();
                            lblLeaderId.Text = reader[0].ToString();
                            lblLeaderName.Text = reader[1].ToString();
                            lblLeaderAddress.Text = reader[2].ToString();
                            lblLeaderTelephone.Text = reader[3].ToString();
                        }
                        reader.Close();
                        con.Close();
                    }
                }
            }

        }

        private void btnDeleteProfile_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("This will erase all the contact/leader related data from the database", "Are you sure?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var personId = lblNic.Text.ToString();
                var con = db.getContactPersonConnection();
                con.Open();
                var command = con.CreateCommand();
                command.CommandText = @"DELETE FROM [Relations] WHERE [Leader] IS $value;DELETE FROM [Relations] WHERE [Subordinate] IS $value1;";
                command.Parameters.AddWithValue("$value", personId);
                command.Parameters.AddWithValue("$value1", personId);
                
                var outval = command.ExecuteNonQuery();
                if (outval > 0)
                {
                    command = con.CreateCommand();
                    command.CommandText = @"DELETE FROM [PersonDetails] WHERE [Id] IS $value;";
                    command.Parameters.AddWithValue("$value", personId);
                    command.ExecuteNonQuery();

                    this.Close();
                    this.parent.Show();
                    
                }
                else
                {
                    MessageBox.Show("Error deleting the person. Contact admin!");
                }
                con.Close();
                return;

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }


        }
    }

}
