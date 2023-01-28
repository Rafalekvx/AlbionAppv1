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
        public Confirm()
        {
            InitializeComponent();
            Instance = this;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                
                sqlcon.Open();
                string sqlcomm = $"INSERT INTO start_run (tier,enchant,current_silver,current_item_value,map_cost,zone,solo_duo,start_time)   VALUES (@tier,@enchant,@current_silver,@current_item_value,@map_cost,@zone,@solo_duo,@start_time) ";
                using (SqlCommand command = new SqlCommand(sqlcomm, sqlcon))
                {
                    command.Parameters.Add("@tier", SqlDbType.Int, 3).Value = int.Parse(Form2.Instance.startModel.tier.ToString());
                    command.Parameters.Add("@enchant", SqlDbType.Int, 3).Value = int.Parse(Form2.Instance.startModel.enchant.ToString());
                    command.Parameters.Add("@current_silver", SqlDbType.Int, 32).Value = int.Parse(Form2.Instance.startModel.current_silver.ToString());
                    command.Parameters.Add("@current_item_value", SqlDbType.Int, 32).Value = int.Parse(Form2.Instance.startModel.current_item_value.ToString());
                    command.Parameters.Add("@map_cost", SqlDbType.Int, 32).Value = int.Parse(Form2.Instance.startModel.map_cost.ToString());
                    command.Parameters.Add("@zone", SqlDbType.VarChar, 50).Value = Form2.Instance.startModel.zone;
                    command.Parameters.Add("@solo_duo", SqlDbType.Int, 32).Value = int.Parse(Form2.Instance.startModel.solo_duo.ToString());
                    command.Parameters.Add("@start_time", SqlDbType.Time, 7).Value = Form2.Instance.startModel.start_time.ToString("hh:mm");
                    command.ExecuteNonQuery();
                }
                    
                sqlcon.Close();
            }

            End_run endRunForm = new End_run();
            endRunForm.ShowDialog();


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

            label1.Text = Form2.Instance.startModel.tier.ToString() ;

            dataFromForm.AutoGenerateColumns = true;
            dataFromForm.AutoSize = true;
            List<start_runModel> list = new List<start_runModel> { Form2.Instance.startModel };

            DataTable dt = new DataTable();

            dt.Columns.Add("Tier");
            dt.Columns.Add(Form2.Instance.startModel.tier.ToString());
            DataRow dr = null;

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
            dr[1] = Form2.Instance.startModel.start_time.ToString();
            dt.Rows.Add(dr);

            dataFromForm.DataSource = dt;
        }
    }
}
