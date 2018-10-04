using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchDatabases
{
    public partial class SearchDB : Form
    {
        public readonly string connstring = Properties.Settings.Default.DBSource + Properties.Settings.Default.ConnectionString + Properties.Settings.Default.DBName + ".s3db";

        public SearchDB()
        {
            InitializeComponent();
        }

        private void GetFromDB_Click(object sender, EventArgs e)
        {
            using (var con = new SQLiteConnection(connstring))
            {

                //open connecting to Database
                try
                {
                    con.Open();
                }
                catch(Exception openConnectingDB)
                {
                    Console.WriteLine("{0} Exception caught", openConnectingDB);
                }

                //select
                string queryEmployee = "SELECT imie,Nazwisko,Status,Stanowisko,Lokalizacja,Notatki,CV from employeeData";

                SQLiteDataAdapter connSQLLITEAdapter = new SQLiteDataAdapter(queryEmployee, con);
                DataSet dataset = new DataSet();
                connSQLLITEAdapter.Fill(dataset);

                //set to data grid
                dataGridView_SearchDB.DataSource = dataset.Tables[0];
            }
        }
    }
}
