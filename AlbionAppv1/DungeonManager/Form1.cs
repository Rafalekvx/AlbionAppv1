using AlbionAppv1.Menu;
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

namespace AlbionAppv1
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=AlbionApp; Integrated Security=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqldata = new SqlDataAdapter("SELECT TOP (1000) start_run.id,start_run.current_silver,end_run.new_silver,start_run.current_item_value,end_run.new_item_value,start_run.start_time,end_time,(end_run.new_silver - start_run.current_silver) + (end_run.new_item_value-start_run.current_item_value) AS profit,DATEDIFF(minute,start_time,end_time) as timer\r\n  FROM [AlbionApp].[dbo].[end_run] inner join AlbionApp.dbo.start_run on  end_run.start_id=start_run.id", sqlcon);
                DataTable dtbl = new DataTable();
                sqldata.Fill(dtbl);

                albiondatav1.DataSource = dtbl;

                sqlcon.Close();
            }
        }

        private void starterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 addForm = new Form2();
            addForm.ShowDialog();
            this.Close();

        }

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu startMenu = new StartMenu();
            startMenu.ShowDialog();
            this.Close();
        }
    }
}
