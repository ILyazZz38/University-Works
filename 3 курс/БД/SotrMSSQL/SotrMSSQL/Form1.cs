using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SotrMSSQL
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Calc"].ConnectionString);
            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Workers", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];

            SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter("SELECT (Salary * WorkedDays) / 20 AS Payed, ((Salary * WorkedDays) / 20) * 0.13 AS Tax, (Salary * WorkedDays) / 20 - ((Salary * WorkedDays) / 20) * 0.13 AS AllSalary, FirstName FROM Workers", sqlConnection);
            DataSet dataSet1 = new DataSet();
            sqlDataAdapter1.Fill(dataSet1);
            dataGridView2.DataSource = dataSet1.Tables[0];

            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter("SELECT * FROM Stationery", sqlConnection);
            DataSet dataSet2 = new DataSet();
            sqlDataAdapter2.Fill(dataSet2);
            dataGridView3.DataSource = dataSet2.Tables[0];

            SqlDataAdapter sqlDataAdapter3 = new SqlDataAdapter("Select StationeryName, (Price * StationerySum) as VolumeSales from Stationery", sqlConnection);
            DataSet dataSet3 = new DataSet();
            sqlDataAdapter3.Fill(dataSet3);
            dataGridView4.DataSource = dataSet3.Tables[0];
        }
    }
}
