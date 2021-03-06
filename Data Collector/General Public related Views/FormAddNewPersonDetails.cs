using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Janaka_Ayya_Software.General_Public_related_Views
{
    public partial class FormAddNewPersonDetails : Form
    {
        Form parent;
        Database db;
        public FormAddNewPersonDetails(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
            db = new Database();
            this.FormClosing += new FormClosingEventHandler(FormAddNewPersonDetails_FormClosed);
        }

        private void FormAddNewPersonDetails_FormClosed(Object sender, FormClosingEventArgs e)
        {
            this.parent.Show();
        }

        private void btnAddDetails_Click(object sender, EventArgs e)
        {

            var name = txtName.Text;
            Regex r = new Regex("^[a-zA-Z]*$");
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name cannot be empty");
                return;
            }
            else if (!r.IsMatch(name))
            {
                MessageBox.Show("Name can only have letters");
                return;
            }

            var address = txtAddress.Text;
            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Address cannot be empty");
                return;
            }

            var phoneNo = txtPhoneNo.Text.ToLower();
            r = new Regex("^[0-9]*$");
            if (string.IsNullOrEmpty(phoneNo))
            {
                MessageBox.Show("Phone Number cannot be empty");
                return;
            }
            else if (!r.IsMatch(phoneNo))
            {
                MessageBox.Show("Phone number can only have numbers");
                return;
            }


            var nic = txtNIC.Text.ToLower();
            r = new Regex("^[a-zA-Z0-9]*$");
            if (string.IsNullOrEmpty(nic))
            {
                MessageBox.Show("ID number cannot be empty");
                return;
            }
            else if (!r.IsMatch(nic))
            {
                MessageBox.Show("ID number cannot contain symbols");
                return;
            }

            var district = txtDistrict.Text;
            r = new Regex("^[a-zA-Z]*$");
            if (string.IsNullOrEmpty(district))
            {
                MessageBox.Show("District cannot be empty");
                return;
            }
            else if (!r.IsMatch(district))
            {
                MessageBox.Show("District can only have letters");
                return;
            }

            var area = txtArea.Text;
            r = new Regex("^[a-zA-Z]*$");
            if (string.IsNullOrEmpty(area))
            {
                MessageBox.Show("Area cannot be empty");
                return;
            }
            else if (!r.IsMatch(area))
            {
                MessageBox.Show("Area can only have letters");
                return;
            }

            var birthday = txtBirdthday.Text.ToLower();
            r = new Regex("^\\d{4}-((0\\d)|(1[012]))-(([012]\\d)|3[01])$");
            if (string.IsNullOrEmpty(birthday))
            {
                MessageBox.Show("Birthday cannot be empty");
                return;
            }
            else if (!r.IsMatch(birthday))
            {
                MessageBox.Show("Birthday should be in yyyy-mm-dd format.");
                return;
            }

            var reason = txtReason.Text;
            var advice = txtAdvice.Text;
            var solved = cbtnSolved.Checked;

            var connection = db.getGeneralPublicConnection();
            connection.Open();
            var cmd = connection.CreateCommand();

            cmd.CommandText = @"
                        INSERT INTO [UserDetails]
                                   ([Id]
                                   ,[Name]
                                   ,[Telephone]
                                   ,[Address]
                                   ,[Area]
                                   ,[District]
                                   ,[Birthday])
                             VALUES
                                   ($id
                                   ,$name
                                   ,$tp
                                   ,$address
                                   ,$area
                                   ,$district
                                   ,$birthday)
                        ";

            cmd.Parameters.AddWithValue("id", nic);
            cmd.Parameters.AddWithValue("$name", name);
            cmd.Parameters.AddWithValue("tp", phoneNo);
            cmd.Parameters.AddWithValue("address", address);
            cmd.Parameters.AddWithValue("area", area);
            cmd.Parameters.AddWithValue("district", district);
            cmd.Parameters.AddWithValue("birthday", birthday);
            
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception x)
            {
                MessageBox.Show("User Already exist! please check");
                return;
            }
            

            cmd = connection.CreateCommand();
            cmd.CommandText = @"
                        INSERT INTO [UserDescriptions]
                               ([Id]
                               ,[Description]
                               ,[Solved]
                               ,[Comments])
                         VALUES
                               ($id
                               ,$details
                               ,$solved
                               ,$comments)

                    ";
            cmd.Parameters.AddWithValue("$id", nic);
            cmd.Parameters.AddWithValue("$details", reason);
            cmd.Parameters.AddWithValue("$solved", solved);
            cmd.Parameters.AddWithValue("$solution", "");
            cmd.Parameters.AddWithValue("$comments", advice);
            cmd.ExecuteNonQuery();

            connection.Close();
            this.Close();

        }
    }
}
