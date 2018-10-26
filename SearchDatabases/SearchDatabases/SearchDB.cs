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
            LoadData();
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        int co_val;

        //set connection
        private void SetConnection()
        {
            sql_con = new SQLiteConnection(connstring);
        }

        //set execute
        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        //set loadDB

        public void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "SELECT imie,Nazwisko,Status,Stanowisko,Lokalizacja,Notatki,CV from employeeData";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView_SearchDB.DataSource = DT;
            co_val = DT.Rows.Count;
            sql_con.Close();
        }



        private void GetFromDB_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button_Added_New_Data_Click(object sender, EventArgs e)
        {
            LoadData();
            int NextRow = co_val + 3;
            string txtQuery = "INSERT INTO employeeData (ID_employeeData,Imie,Nazwisko,Status,Stanowisko,Lokalizacja,Notatki,CV) values ('"+NextRow+"','" + textBox_imie.Text+ "','" +textBox_nazwisko.Text+ "','" +textBox_Status.Text+ "','" +textBox_Stanowisko.Text + "','" +textBox_lokalizacja.Text + "','" +textBox_notatki.Text+ "','" +textBox_CV.Text+ "')";
            ExecuteQuery(txtQuery);
            LoadData();
        }
    }
}
