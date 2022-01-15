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

namespace MSSQLClientContractsForm
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void ClientTableUpdate()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Clients", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            ClientData.DataSource = dataSet.Tables[0];
            ClientDataEdit.DataSource = dataSet.Tables[0];
        }

        private void ContractTableUpdate(int ClientID, bool inSearch)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"Select * from Contracts Where ClientId = {ClientID}", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            if (inSearch)
                ContractData.DataSource = dataSet.Tables[0];
            else
                ContractDataEdit.DataSource = dataSet.Tables[0]; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ClientContractsDB"].ConnectionString);
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("Database connection established");
            }
            ClientTableUpdate();
            this.DateSearch.Enabled = false;
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Clients (Organisation_Name, Organisation_Address, Boss) VALUES (@Organisation_Name, @Organisation_Address, @Boss)", sqlConnection);
            command.Parameters.AddWithValue("Organisation_Name", OrgNameEdit.Text);
            command.Parameters.AddWithValue("Organisation_Address", AddressEdit.Text);
            command.Parameters.AddWithValue("Boss", BossEdit.Text);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Client added!");
            }
            else
            {
                MessageBox.Show("Client not added!");
            }
            ClientTableUpdate();
        }

        private void OrgNameSearch_TextChanged(object sender, EventArgs e)
        {
            (ClientData.DataSource as DataTable).DefaultView.RowFilter = $"Organisation_Name LIKE '%{OrgNameSearch.Text}%'";
        }

        private void AddressSearch_TextChanged(object sender, EventArgs e)
        {
            (ClientData.DataSource as DataTable).DefaultView.RowFilter = $"Organisation_Address LIKE '%{AddressSearch.Text}%'";
        }

        private void BossSearch_TextChanged(object sender, EventArgs e)
        {
            (ClientData.DataSource as DataTable).DefaultView.RowFilter = $"Boss LIKE '%{BossSearch.Text}%'";
        }

        private void ClientDataEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClientDataEdit.Rows[ClientDataEdit.SelectedCells[0].RowIndex].Cells[0].Value != null)
                {
                    int ClientID = Convert.ToInt32(ClientDataEdit.Rows[ClientDataEdit.SelectedCells[0].RowIndex].Cells[0].Value);
                    ContractTableUpdate(ClientID, false);
                    OrgNameEdit.Text = Convert.ToString(ClientDataEdit.Rows[ClientDataEdit.SelectedCells[0].RowIndex].Cells[1].Value);
                    AddressEdit.Text = Convert.ToString(ClientDataEdit.Rows[ClientDataEdit.SelectedCells[0].RowIndex].Cells[2].Value);
                    BossEdit.Text = Convert.ToString(ClientDataEdit.Rows[ClientDataEdit.SelectedCells[0].RowIndex].Cells[3].Value);
                    AddContractButton.Enabled = true;
                    ChangeContractButton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("You have selected an empty cell");
                }
            }
            catch
            {
                MessageBox.Show("You have not selected a cell");
            }
        }

        private void AddContractButton_Click(object sender, EventArgs e)
        {
            int ClientID = Convert.ToInt32(ClientDataEdit.Rows[ClientDataEdit.SelectedCells[0].RowIndex].Cells[0].Value);
            SqlCommand command = new SqlCommand("insert into Contracts(Contract_Date, Contract_sum, ClientId) values (@Contract_Date, @Contract_sum, @ClientId)", sqlConnection);
            command.Parameters.AddWithValue("Contract_Date", DateEdit.Value);
            command.Parameters.AddWithValue("Contract_sum", SumEdit.Text);
            command.Parameters.AddWithValue("ClientId", ClientID);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Contract added!");
            }
            else
            {
                MessageBox.Show("Contract not added!");
            }
            ContractTableUpdate(ClientID, false);
        }

        private void ClientData_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClientData.Rows[ClientData.SelectedCells[0].RowIndex].Cells[0].Value != null)
                {
                    int ClientID = Convert.ToInt32(ClientData.Rows[ClientData.SelectedCells[0].RowIndex].Cells[0].Value);
                    ContractTableUpdate(ClientID, true);
                    this.DateSearch.Enabled = true;
                    SumSearch.ReadOnly = false;
                }
                else
                {
                    MessageBox.Show("You have selected an empty cell");
                }
            }
            catch
            {
                MessageBox.Show("You have not selected a cell");
            }
        }

        private void SumSearch_TextChanged(object sender, EventArgs e)
        {
                if (SumSearch.Text != "")
                {
                    (ContractData.DataSource as DataTable).DefaultView.RowFilter = $"Contract_sum = {SumSearch.Text}";
                }
        }

        private void DateSearch_ValueChanged(object sender, EventArgs e)
        {
            (ContractData.DataSource as DataTable).DefaultView.RowFilter = $"Contract_Date = '{DateSearch.Value.Day}.{DateSearch.Value.Month}.{DateSearch.Value.Year}'";
        }

        private void ContractDataEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (ContractDataEdit.Rows[ContractDataEdit.SelectedCells[0].RowIndex].Cells[0].Value != null)
                {
                    SumEdit.Text = Convert.ToString(ContractDataEdit.Rows[ContractDataEdit.SelectedCells[0].RowIndex].Cells[2].Value);
                    DateEdit.Value = Convert.ToDateTime(ContractDataEdit.Rows[ContractDataEdit.SelectedCells[0].RowIndex].Cells[3].Value);
                }
                else
                {
                    MessageBox.Show("You have selected an empty cell");
                }
            }
            catch
            {
                MessageBox.Show("You have not selected a cell");
            }
        }

        private void ChangeClientButton_Click(object sender, EventArgs e)
        {
            int ClientID = Convert.ToInt32(ClientDataEdit.Rows[ClientDataEdit.SelectedCells[0].RowIndex].Cells[0].Value);
            SqlCommand command = new SqlCommand("update Clients Set Organisation_Name = @Organisation_Name, Organisation_Address = @Organisation_Address, Boss = @Boss where ClientId = @ClientId", sqlConnection);
            command.Parameters.AddWithValue("Organisation_Name", OrgNameEdit.Text);
            command.Parameters.AddWithValue("Organisation_Address", AddressEdit.Text);
            command.Parameters.AddWithValue("Boss", BossEdit.Text);
            command.Parameters.AddWithValue("ClientId", ClientID);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Client changed!");
            }
            else
            {
                MessageBox.Show("Client not changed!");
            }
            ClientTableUpdate();
        }

        private void ChangeContractButton_Click(object sender, EventArgs e)
        {
            int ContractID = Convert.ToInt32(ContractDataEdit.Rows[ContractDataEdit.SelectedCells[0].RowIndex].Cells[0].Value);
            int ClientID = Convert.ToInt32(ClientDataEdit.Rows[ClientDataEdit.SelectedCells[0].RowIndex].Cells[0].Value);
            SqlCommand command = new SqlCommand("update Contracts Set Contract_sum = @Contract_sum, Contract_Date = @Contract_Date where ContractId = @ContractId", sqlConnection);
            command.Parameters.AddWithValue("Contract_Date", DateEdit.Value);
            command.Parameters.AddWithValue("Contract_sum", SumEdit.Text);
            command.Parameters.AddWithValue("ContractId", ContractID);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Contract changed!");
            }
            else
            {
                MessageBox.Show("Contract not changed!");
            }
            ContractTableUpdate(ClientID, false);
        }
    }
}
