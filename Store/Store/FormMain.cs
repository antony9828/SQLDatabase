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
            using (connection = new SqlConnection(connectionString))
            using(SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Specific_Order", connection))
            {
                DataTable Specific_Order_Table = new DataTable();
                adapter.Fill(Specific_Order_Table);

                listBox0.DisplayMember = "Name";
                listBox0.ValueMember = "Id";
                listBox0.DataSource = Specific_Order_Table;

                listBox1.DisplayMember = "Items";
                listBox1.ValueMember = "Id";
                listBox1.DataSource = Specific_Order_Table;

                listBox2.DisplayMember = "Price";
                listBox2.ValueMember = "Id";
                listBox2.DataSource = Specific_Order_Table;

                listBox3.DisplayMember = "Status";
                listBox3.ValueMember = "Id";
                listBox3.DataSource = Specific_Order_Table;
            }
                
        }

        private void PopulateProducts()
        {

            string query = "SELECT a.Name FROM Product a " + 
                "INNER JOIN Specific_Order__Product b ON a.Id = b.Product_Id " +
                "WHERE b.Specific_Order_Id = @Specific_Order_Id";
            using (connection = new SqlConnection(connectionString))
            using(SqlCommand command =  new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@Specific_Order_Id", listBox0.SelectedValue);

                DataTable SpecificProduct = new DataTable();
                adapter.Fill(SpecificProduct);

                listBox4.DisplayMember = "Name";
                listBox4.ValueMember = "Id";
                listBox4.DataSource = SpecificProduct;
            }

        }

        private void listBox0_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateProducts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Specific_Order VALUES (@Specific_Order_Name, 0, 0, 'Pending')";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@Specific_Order_Name", textBox1.Text);

                command.ExecuteScalar();
            }
            PopulateSpecific_Objects();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Specific_Order SET Name = @Specific_Order_Name WHERE Id = @Specific_Order_Id";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@Specific_Order_Name", textBox1.Text);
                command.Parameters.AddWithValue("@Specific_Order_Id", listBox0.SelectedValue);

                command.ExecuteScalar();
            }
            PopulateSpecific_Objects();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Specific_Order WHERE Id = @Specific_Order_Id";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@Specific_Order_Id", listBox0.SelectedValue);

                command.ExecuteScalar();
            }
            PopulateSpecific_Objects();
        }
    }
}
