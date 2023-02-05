using AlbionAppv1.Crafting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbionAppv1.Menu
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void DungeonButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 dungForm = new Form1();
            dungForm.ShowDialog();
            this.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void CraftingButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CraftingForm craftingForm = new CraftingForm();
            craftingForm.ShowDialog();
            this.Close();
        }
    }
}
