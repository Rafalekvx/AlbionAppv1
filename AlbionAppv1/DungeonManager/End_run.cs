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
    public partial class End_run : Form
    {

        public string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=AlbionApp; Integrated Security=True;";
        public End_run()
        {
            InitializeComponent();
        }

        private void endRunButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {

                sqlcon.Open();
                SqlDataAdapter getStartRunId = new SqlDataAdapter("SELECT MAX(id) from start_run", sqlcon);
                int startRunId = 0;
                DataTable dtbl = new DataTable();
                getStartRunId.Fill(dtbl);

                startRunId = dtbl.Rows[0].Field<int>(0);


                string sqlcomm = $"INSERT INTO end_run (new_silver,new_item_value,end_time,start_id)   VALUES (@new_silver,@new_item_value,@end_time,@start_id) ";
                using (SqlCommand command = new SqlCommand(sqlcomm, sqlcon))
                {
                    command.Parameters.Add("@new_silver", SqlDbType.Int, 32).Value = int.Parse(newSilver.Text);
                    command.Parameters.Add("@new_item_value", SqlDbType.Int, 32).Value = int.Parse(newItemValue.Text);
                    command.Parameters.Add("@end_time", SqlDbType.Time, 7).Value = endRunTimePicker.Value.ToString("hh:mm");
                    command.Parameters.Add("@start_id", SqlDbType.Int, 32).Value = startRunId;
                    command.ExecuteNonQuery();
                }

                sqlcon.Close();
            }

            this.Hide();
            Form1 backToMenu = new Form1();
            backToMenu.ShowDialog();
            this.Close();
        }
    }
}
