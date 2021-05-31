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

namespace CalculationOfSeniority
{
    public partial class Seniority : Form
    {
        public Seniority()
        {
            InitializeComponent();
            ConnectionToDb();
        }
        private void ConnectionToDb()
        {
            string conStr = @"Data Source=SERGEEV;Initial Catalog=master;User Id = sa; Password = 123";

            SqlConnection connection = new SqlConnection(conStr);

            connection.Open();

            string sql = "select DateBegin as [Дата начала] from Seniority";

            SqlCommand createCommand = new SqlCommand(sql, connection);
            createCommand.ExecuteNonQuery();
            SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
            DataTable dt = new DataTable("Seniority"); // В скобках указываем название таблицы
            dataAdp.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView; // Сам вывод 
            connection.Close();
        }
    }
}
