using AlbionAppv1.Models;
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
    public partial class Confirm : Form
    {
        public static Confirm Instance;
        public string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=AlbionApp; Integrated Security=True;";
        public List<start_runModel> list = new List<start_runModel> { Form2.Instance.startModel };
        public DataTable dt = new DataTable();

        public Confirm()
        {
            InitializeComponent();
            Instance = this;
        }


        private DataTable MakePivotTable(DataTable mainTable)
        {
            DataTable pivotTable = new DataTable();
            DataRow dr = null;


            for (int i = 0; i <= mainTable.Rows.Count; i++)
            {
                pivotTable.Columns.Add(new DataColumn(mainTable.Columns[i].ColumnName, typeof(String)));
            }


            for (int cols = 0; cols < mainTable.Columns.Count; cols++)
            {
                dr = pivotTable.NewRow();
                for (int rows = 0; rows < mainTable.Rows.Count; rows++)
                {
                    if (rows < mainTable.Columns.Count)
                    {
                        dr[0] = mainTable.Columns[cols].ColumnName;
                        dr[rows + 1] = mainTable.Rows[rows][cols];
                    }
                }
                pivotTable.Rows.Add(dr);
            }
            return pivotTable;
        }

        private void Confirm_Load(object sender, EventArgs e)
        {

            dataFromForm.AutoGenerateColumns = true;
            dataFromForm.AutoSize = true;
            

            dt.Columns.Add("Name");
            dt.Columns.Add("Value");
            DataRow dr = null;

            dr = dt.NewRow();
            dr[0] = "Tier";
            dr[1] = Form2.Instance.startModel.tier.ToString();
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "Enchant";
            dr[1] = Form2.Instance.startModel.enchant.ToString();
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "Current Silver";
            dr[1] = Form2.Instance.startModel.current_silver.ToString();
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "Current Item Value";
            dr[1] = Form2.Instance.startModel.current_item_value.ToString();
            dt.Rows.Add(dr);


            dr = dt.NewRow();
            dr[0] = "Map Cost";
            dr[1] = Form2.Instance.startModel.map_cost.ToString();
            dt.Rows.Add(dr);


            dr = dt.NewRow();
            dr[0] = "Zone";
            dr[1] = Form2.Instance.startModel.zone;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "Type";
            dr[1] = Form2.Instance.startModel.solo_duo.ToString();
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr[0] = "Start Time";
            dr[1] = Form2.Instance.startModel.start_time.ToString("hh:mm");
            dt.Rows.Add(dr);

            dataFromForm.DataSource = dt;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {

                sqlcon.Open();
                string sqlcomm = $"INSERT INTO start_run (tier,enchant,current_silver,current_item_value,map_cost,zone,solo_duo,start_time)   VALUES (@tier,@enchant,@current_silver,@current_item_value,@map_cost,@zone,@solo_duo,@start_time) ";
                using (SqlCommand command = new SqlCommand(sqlcomm, sqlcon))
                {
                    command.Parameters.Add("@tier", SqlDbType.Int, 3).Value = int.Parse(dt.Rows[0][1].ToString()); ;
                    command.Parameters.Add("@enchant", SqlDbType.Int, 3).Value = int.Parse(dt.Rows[1][1].ToString());
                    command.Parameters.Add("@current_silver", SqlDbType.Int, 32).Value = int.Parse(dt.Rows[2][1].ToString());
                    command.Parameters.Add("@current_item_value", SqlDbType.Int, 32).Value = int.Parse(dt.Rows[3][1].ToString());
                    command.Parameters.Add("@map_cost", SqlDbType.Int, 32).Value = int.Parse(dt.Rows[4][1].ToString());
                    command.Parameters.Add("@zone", SqlDbType.VarChar, 50).Value = dt.Rows[5][1].ToString();
                    command.Parameters.Add("@solo_duo", SqlDbType.Int, 32).Value = int.Parse(dt.Rows[6][1].ToString());
                    command.Parameters.Add("@start_time", SqlDbType.Time, 7).Value = dt.Rows[7][1].ToString();
                    command.ExecuteNonQuery();
                }

                sqlcon.Close();
            }
            this.Hide();
            End_run endRunForm = new End_run();
            endRunForm.ShowDialog();
            this.Close();

        }

    }
}
