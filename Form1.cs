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
        private void Add_button_Click(object sender, EventArgs e)
        {
            string conStr = @"Data Source=SERGEEV\SERGEEV;Initial Catalog=master;User Id = sa; Password = 123";

            SqlConnection connection = new SqlConnection(conStr);

            connection.Open();

            ////string sql = "select DateBegin as [Дата начала], DateEnd as [Дата конец], WorkExperience as [Стаж] from  Seniority";

            string sql = "INSERT INTO [Seniority] (DateBegin, DateEnd, WorkExperience) VALUES (@DateBegin, @DateEnd, @WorkExperience)";

            SqlCommand createCommand = new SqlCommand(sql, connection);

            createCommand.Parameters.AddWithValue("@DateBegin", DateBegin.Value.ToString()); //или без ToString();
            createCommand.Parameters.AddWithValue("@DateEnd", DateEnd.Value.ToString()); //или без ToString();
            createCommand.Parameters.AddWithValue("@WorkExperience", DateEnd.Value.ToString()); //или без ToString();

            createCommand.ExecuteNonQuery();

        }

        private void ConnectionToDb()
        {
            string conStr = @"Data Source=SERGEEV\SERGEEV;Initial Catalog=master;User Id = sa; Password = 123";

            SqlConnection connection = new SqlConnection(conStr);

            connection.Open();

            string sql = "select DateBegin as [Дата начала], DateEnd as [Дата конец], WorkExperience as [Стаж] from  Seniority";

            SqlCommand createCommand = new SqlCommand(sql, connection);
            createCommand.ExecuteNonQuery();
            SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
            DataTable dt = new DataTable("Seniority"); // В скобках указываем название таблицы
            dataAdp.Fill(dt);
            DateBase.DataSource = dt.DefaultView; // Сам вывод 
            connection.Close();
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
        }
    }

}
