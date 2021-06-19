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
        SqlConnection connection;
        SqlCommand cmd;

        public Seniority()
        {
            CreateSqlConnection();
            InitializeComponent();
        }

        private void CreateSqlConnection()
        {
            string conStr = @"Data Source=SERGEEV\nikita;Initial Catalog=master;User Id = sa; Password = 123";
            connection = new SqlConnection(conStr);
            connection.Open();
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = connection;
        }

        private void Seniority_Load(object sender, EventArgs e)
        {
            string sql = "select DateBegin as [Дата начала], DateEnd as [Дата окончания] from  Seniority";
            SqlCommand createCommand = new SqlCommand(sql, connection);
            createCommand.ExecuteNonQuery();
            SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
            DataTable dt = new DataTable("Seniority"); // В скобках указываем название таблицы
            dataAdp.Fill(dt);
            DateBase.DataSource = dt.DefaultView; // Сам вывод 
       
        }
        private void Add_button_Click(object sender, EventArgs e)
        {
            cmd.CommandText = $"INSERT into [Seniority] (DateBegin, DateEnd) VALUES " +
            $"(convert(date,'{DateBegin.Value.ToShortDateString()}',104), " +
            $"convert(date,'{DateEnd.Value.ToShortDateString()}',104))";
            cmd.ExecuteNonQuery();
            Seniority_Load(sender, e);
        }

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            Seniority_Load(sender, e);
        }
    }
}
