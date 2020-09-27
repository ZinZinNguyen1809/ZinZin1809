using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        { 
            InitializeComponent();
            LoadHat();
            LoadAo();
            LoadQuan();
            LoadSock();
        }
        void LoadHat()
        {
            string connectionStr = "Data Source=DESKTOP-K2OM0JJ;Initial Catalog=QuanlyQuanAo;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);
            
            string query ="SELECT* FROM dbo.Hat";

            connection.Open();
            
            SqlCommand Command = new SqlCommand(query, connection);
            
            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(Command);

            adapter.Fill(data);

            connection.Close();

            dataViewHat.DataSource = data;
        }
        void LoadAo()
        {
            string connectionStr = "Data Source=DESKTOP-K2OM0JJ;Initial Catalog=QuanlyQuanAo;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);

            string query = "SELECT* FROM dbo.Ao";

            connection.Open();

            SqlCommand Command = new SqlCommand(query, connection);

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(Command);

            adapter.Fill(data);

            connection.Close();

            dataViewAo.DataSource = data;
        }
        void LoadQuan()
        {
            string connectionStr = "Data Source=DESKTOP-K2OM0JJ;Initial Catalog=QuanlyQuanAo;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);

            string query = "SELECT* FROM dbo.Quan";

            connection.Open();

            SqlCommand Command = new SqlCommand(query, connection);

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(Command);

            adapter.Fill(data);

            connection.Close();

            dataViewQuan.DataSource = data;
        }
        void LoadSock()
        {
            string connectionStr = "Data Source=DESKTOP-K2OM0JJ;Initial Catalog=QuanlyQuanAo;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);

            string query = "SELECT* FROM dbo.Sock";

            connection.Open();

            SqlCommand Command = new SqlCommand(query, connection);

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(Command);

            adapter.Fill(data);

            connection.Close();

            dataViewSock.DataSource = data;
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tpQuan_Click(object sender, EventArgs e)
        {

        }

        private void tpSock_Click(object sender, EventArgs e)
        {

        }
    }
}
