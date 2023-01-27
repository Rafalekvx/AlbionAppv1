using AlbionAppv1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbionAppv1
{
    public partial class Form2 : Form
    {
        public start_runModel startModel = new start_runModel();
        public static Form2 Instance;
        public Form2()
        {
            InitializeComponent();
            Instance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            startModel.tier = int.Parse(tierBox.Text);
            startModel.current_silver = int.Parse(currentSilver.Text);
            startModel.current_item_value = int.Parse(currentItemValue.Text);
            startModel.map_cost = int.Parse(mapCost.Text);
            startModel.zone = zone.Text;
            startModel.solo_duo = int.Parse(type.Text);
            startModel.start_time = startTimePicker.Value;

            Confirm confForm = new Confirm();
            confForm.ShowDialog();
        }
    }
}
