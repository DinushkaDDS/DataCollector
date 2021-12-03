
using Microsoft.Data.Sqlite;
using System;
using System.IO;
using System.Windows.Forms;

namespace Janaka_Ayya_Software
{

   
    public class Database
    {
        private readonly SqliteConnection dbconnectionPublic;
        private readonly SqliteConnection dbconnectionContacts;

        private static readonly string cmd1 = @"
                                CREATE TABLE ""UserDetails"" (
	                                        ""Id""	TEXT NOT NULL UNIQUE,
	                                        ""Name""	TEXT NOT NULL,
	                                        ""Telephone""	TEXT NOT NULL,
	                                        ""Address""	TEXT,
	                                        ""Area""	TEXT NOT NULL,
	                                        ""District""	TEXT NOT NULL,
	                                        ""Birthday""	TEXT NOT NULL,
	                                        PRIMARY KEY(""Id"")
                                        );
                                        CREATE TABLE ""UserDescriptions"" (
	                                        ""Id""	TEXT NOT NULL,
	                                        ""Description""	TEXT NOT NULL,
	                                        ""Solved""	NUMERIC NOT NULL,
	                                        ""Comments""	TEXT,
	                                        FOREIGN KEY(""Id"") REFERENCES ""UserDetails""(""Id"")
                                        );";

        private static readonly string cmd2 = @"
                                 CREATE TABLE ""PersonDetails"" (
	                                        ""Id""	TEXT NOT NULL,
	                                        ""Name""	TEXT NOT NULL,
	                                        ""Telephone""	TEXT NOT NULL,
	                                        ""Address""	TEXT NOT NULL,
	                                        ""Area""	TEXT NOT NULL,
	                                        ""District""	TEXT NOT NULL,
	                                        ""BirthDay""	TEXT NOT NULL,
	                                        PRIMARY KEY(""Id"")
                                        );
                                        CREATE TABLE ""Relations"" (
	                                        ""Leader""	TEXT NOT NULL,
	                                        ""Subordinate""	TEXT NOT NULL,
	                                        FOREIGN KEY(""Leader"") REFERENCES ""PersonDetails""(""Id""),
	                                        FOREIGN KEY(""Subordinate"") REFERENCES ""PersonDetails""(""Id"")
                                        );
                                ";


        public Database()
        {
            try
            {
                this.dbconnectionPublic = new SqliteConnection("Data Source="+ AppContext.BaseDirectory + "/Databases/General_Public;foreign keys = true;");
                if (!Directory.Exists("./Databases"))
                {
                    Directory.CreateDirectory(AppContext.BaseDirectory + "/Databases");
                }
                if (!File.Exists("./Databases/General_Public"))
                {
                    dbconnectionPublic.Open();
                    var cmd = dbconnectionPublic.CreateCommand();
                    cmd.CommandText = cmd1;
                    cmd.ExecuteNonQuery();
                    dbconnectionPublic.Close();
                    System.Windows.Forms.MessageBox.Show("Database General Public were successfully created!");
                }

                this.dbconnectionContacts = new SqliteConnection("Data Source=" + AppContext.BaseDirectory + "//Databases/Contact_Persons;foreign keys = true;");
                if (!Directory.Exists("./Databases"))
                {
                    Directory.CreateDirectory(AppContext.BaseDirectory + "/Databases");
                }
                if (!File.Exists("./Databases/Contact_Persons"))
                {
                    dbconnectionContacts.Open();
                    var cmd = dbconnectionContacts.CreateCommand();
                    cmd.CommandText = cmd2;
                    cmd.ExecuteNonQuery();
                    dbconnectionContacts.Close();
                    System.Windows.Forms.MessageBox.Show("Database Contact Persons were successfully created!");
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Databases creation failed. Please contact Admins!.");
                Application.Exit();
            }
            
        }

        public SqliteConnection getGeneralPublicConnection()
        {
            return dbconnectionPublic;
        }

        public SqliteConnection getContactPersonConnection()
        {
            return dbconnectionContacts;
        }

    }
}
