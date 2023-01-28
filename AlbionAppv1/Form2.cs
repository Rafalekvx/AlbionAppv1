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

            tierSelect.DataSource = new ComboItem[] {
                new ComboItem{Id = 4, Text ="4" },
                new ComboItem{Id = 5, Text ="5" },
                new ComboItem{Id = 6, Text ="6" },
                new ComboItem{Id = 7, Text ="7" },
                new ComboItem{Id = 8, Text ="8" },
                 };

            enchantSelect.DataSource = new ComboItem[] {
                new ComboItem{Id = 1, Text ="-1" },
                new ComboItem{Id = 1, Text ="0" },
                new ComboItem{Id = 1, Text ="1" },
                new ComboItem{Id = 1, Text ="2" },
                };         
            
            zoneSelect.DataSource = new ComboItem[] {
                new ComboItem{Id = 1, Text ="Blue" },
                new ComboItem{Id = 1, Text ="Yellow" },
                new ComboItem{Id = 1, Text ="Red" },
                new ComboItem{Id = 1, Text ="Black" },
                };

            typeSelect.DataSource = new ComboItem[] {
                new ComboItem{Id = 1, Text ="Solo" },
                new ComboItem{Id = 2, Text ="Duo" },
                new ComboItem{Id = 3, Text ="Group" }
                };

        }

        private void button1_Click(object sender, EventArgs e)
        {

            startModel.tier = int.Parse(tierSelect.SelectedValue.ToString());
            startModel.enchant = int.Parse(enchantSelect.SelectedValue.ToString());
            startModel.current_silver = int.Parse(currentSilver.Text);
            startModel.current_item_value = int.Parse(currentItemValue.Text);
            startModel.map_cost = int.Parse(mapCost.Text);
            startModel.zone = zoneSelect.SelectedValue.ToString();
            startModel.solo_duo = int.Parse(typeSelect.SelectedValue.ToString());
            startModel.start_time = startTimePicker.Value;

            Confirm confForm = new Confirm();
            confForm.ShowDialog();
        }
    }
}
