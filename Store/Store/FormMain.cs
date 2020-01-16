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
using System.Data.SqlClient;

namespace Store
{
    public partial class FormMain : Form
    {
        SqlConnection connection;
        SqlDataAdapter adapter;
        SqlCommand command;

        string connectionString;

        public FormMain()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["Store.Properties.Settings.StoreConnectionString"].ConnectionString;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            PopulateSpecific_Objects();
        }

        private void PopulateSpecific_Objects()
        {
            try { connection = new SqlConnection(connectionString); }
            catch { MessageBox.Show("Connection error"); }
            try { adapter = new SqlDataAdapter("SELECT * FROM Specific_Order", connection); }
            catch { MessageBox.Show("Data Adapter error"); }

            using (connection)
            using(adapter)
            {
                DataTable Specific_Order_Table = new DataTable();
                adapter.Fill(Specific_Order_Table);

                nameList.DisplayMember = "Name";
                nameList.ValueMember = "Id";
                nameList.DataSource = Specific_Order_Table;

                itemsListSpecificOrder.DisplayMember = "Items";
                itemsListSpecificOrder.ValueMember = "Id";
                itemsListSpecificOrder.DataSource = Specific_Order_Table;

                priceList.DisplayMember = "Price";
                priceList.ValueMember = "Id";
                priceList.DataSource = Specific_Order_Table;

                statusList.DisplayMember = "Status";
                statusList.ValueMember = "Id";
                statusList.DataSource = Specific_Order_Table;
            }
                
        }

        private void PopulateProducts()
        {
            string query = "SELECT a.Name FROM Product a " +
               "INNER JOIN Specific_Order__Product b ON a.Id = b.Product_Id " +
               "WHERE b.Specific_Order_Id = @Specific_Order_Id";

            try { connection = new SqlConnection(connectionString); }
            catch { MessageBox.Show("Connection error"); }
            try { command = new SqlCommand(query, connection); }
            catch { MessageBox.Show("Command error"); }
            try { adapter = new SqlDataAdapter(command); }
            catch { MessageBox.Show("Data Adapter error"); }

            using (connection)
            using(command)
            using (adapter)
            {
                try { command.Parameters.AddWithValue("@Specific_Order_Id", nameList.SelectedValue); }
                catch { MessageBox.Show("Adding value error (join)"); }

                DataTable SpecificProduct = new DataTable();
                adapter.Fill(SpecificProduct);

                itemListProduct.DisplayMember = "Name";
                itemListProduct.ValueMember = "Id";
                itemListProduct.DataSource = SpecificProduct;
            }

        }

        private void listBox0_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateProducts();
            //Task task = new Task(PopulateProducts);
            //task.Start();
        }

        private async void AddOrder_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Specific_Order VALUES (@Specific_Order_Name, 0, 0, 'Pending')";

            try { connection = new SqlConnection(connectionString); }
            catch { MessageBox.Show("Connection error"); }
            try { command = new SqlCommand(query, connection); }
            catch { MessageBox.Show("Command error"); }

            using (connection)
            using (command)
            {
                try { await connection.OpenAsync(); }
                catch { MessageBox.Show("Connection Error (new order)"); }

                try { command.Parameters.AddWithValue("@Specific_Order_Name", enterField.Text); }
                catch { MessageBox.Show("Adding value error (new order)"); }

                try { await command.ExecuteScalarAsync(); }
                catch { MessageBox.Show("Execute Scalar error (new order)"); }
            }
            PopulateSpecific_Objects();
        }

        private async void ChangeOrder_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Specific_Order SET Name = @Specific_Order_Name WHERE Id = @Specific_Order_Id";

            try { connection = new SqlConnection(connectionString); }
            catch { MessageBox.Show("Connection error"); }
            try { command = new SqlCommand(query, connection); }
            catch { MessageBox.Show("Command error"); }

            using (connection)
            using (command)
            {
                try { await connection.OpenAsync(); }
                catch { MessageBox.Show("Connection Error (change order)"); }

                try { command.Parameters.AddWithValue("@Specific_Order_Name", enterField.Text); }
                catch { MessageBox.Show("Adding value error (change order)"); }

                try { command.Parameters.AddWithValue("@Specific_Order_Id", nameList.SelectedValue); }
                catch { MessageBox.Show("Adding value error (change order)"); }

                try { await command.ExecuteScalarAsync(); }
                catch { MessageBox.Show("Execute Scalar error (change order)"); }
            }
            PopulateSpecific_Objects();
        }

        private async void DeleteOrder_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Specific_Order WHERE Id = @Specific_Order_Id";

            try { connection = new SqlConnection(connectionString); }
            catch { MessageBox.Show("Connection error"); }
            try { command = new SqlCommand(query, connection); }
            catch { MessageBox.Show("Command error"); }

            using (connection)
            using (command)
            {
                try { await connection.OpenAsync(); }
                catch { MessageBox.Show("Connection Error (delete order)"); }

                try { command.Parameters.AddWithValue("@Specific_Order_Id", nameList.SelectedValue); }
                catch { MessageBox.Show("Adding value error (delete order)"); }

                try { await command.ExecuteScalarAsync(); }
                catch { MessageBox.Show("Execute Scalar error (delete order)"); }
            }
            PopulateSpecific_Objects();
        }
    }
}
