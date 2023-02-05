using AlbionAppv1.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbionAppv1.Crafting
{
    public partial class CraftingForm : Form
    {
        public CraftingForm()
        {
            InitializeComponent();
        }

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartMenu startMenu = new StartMenu();
            startMenu.ShowDialog();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                ItemBox1_0.Visible = true;
                ItemBox1_1.Visible = true;
                ItemBox1_2.Visible = true;
                PriceLabel.Visible = true;
                NameLabel.Visible = true;
                AmountLabel.Visible = true;
                SilverTextBox.Visible = true;
                SilverLabel.Visible = true;
            }
            else
            {
                ItemBox1_0.Visible = false;
                ItemBox1_1.Visible = false;
                ItemBox1_2.Visible = false;
                PriceLabel.Visible = false;
                NameLabel.Visible = false;
                AmountLabel.Visible = false;
                SilverTextBox.Visible = false;
                SilverLabel.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                ItemBox1_0.Visible = true;
                ItemBox1_1.Visible = true;
                ItemBox1_2.Visible = true;
                ItemBox2_0.Visible = true;
                ItemBox2_1.Visible = true;
                ItemBox2_2.Visible = true;
                PriceLabel.Visible = true;
                NameLabel.Visible = true;
                AmountLabel.Visible = true;
                SilverTextBox.Visible = true;
                SilverLabel.Visible = true;
            }
            else
            {
                ItemBox1_0.Visible = false;
                ItemBox1_1.Visible = false;
                ItemBox1_2.Visible = false;
                ItemBox2_0.Visible = false;
                ItemBox2_1.Visible = false;
                ItemBox2_2.Visible = false;
                PriceLabel.Visible = false;
                NameLabel.Visible = false;
                AmountLabel.Visible = false;
                SilverTextBox.Visible = false;
                SilverLabel.Visible = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                ItemBox1_0.Visible = true;
                ItemBox1_1.Visible = true;
                ItemBox1_2.Visible = true;
                ItemBox2_0.Visible = true;
                ItemBox2_1.Visible = true;
                ItemBox2_2.Visible = true;
                ItemBox3_0.Visible = true;
                ItemBox3_1.Visible = true;
                ItemBox3_2.Visible = true;
                PriceLabel.Visible = true;
                NameLabel.Visible = true;
                AmountLabel.Visible = true;
                SilverTextBox.Visible = true;
                SilverLabel.Visible = true;
            }
            else
            {
                ItemBox1_0.Visible = false;
                ItemBox1_1.Visible = false;
                ItemBox1_2.Visible = false;
                ItemBox2_0.Visible = false;
                ItemBox2_1.Visible = false;
                ItemBox2_2.Visible = false;
                ItemBox3_0.Visible = false;
                ItemBox3_1.Visible = false;
                ItemBox3_2.Visible = false;
                PriceLabel.Visible = false;
                NameLabel.Visible = false;
                AmountLabel.Visible = false;
                SilverTextBox.Visible = false;
                SilverLabel.Visible = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                ItemBox1_0.Visible = true;
                ItemBox1_1.Visible = true;
                ItemBox1_2.Visible = true;
                ItemBox2_0.Visible = true;
                ItemBox2_1.Visible = true;
                ItemBox2_2.Visible = true;
                ItemBox3_0.Visible = true;
                ItemBox3_1.Visible = true;
                ItemBox3_2.Visible = true;
                ItemBox4_0.Visible = true;
                ItemBox4_1.Visible = true;
                ItemBox4_2.Visible = true;
                PriceLabel.Visible = true;
                NameLabel.Visible = true;
                AmountLabel.Visible = true;
                SilverTextBox.Visible = true;
                SilverLabel.Visible = true;
            }
            else
            {
                ItemBox1_0.Visible = false;
                ItemBox1_1.Visible = false;
                ItemBox1_2.Visible = false;
                ItemBox2_0.Visible = false;
                ItemBox2_1.Visible = false;
                ItemBox2_2.Visible = false;
                ItemBox3_0.Visible = false;
                ItemBox3_1.Visible = false;
                ItemBox3_2.Visible = false;
                ItemBox4_0.Visible = false;
                ItemBox4_1.Visible = false;
                ItemBox4_2.Visible = false;
                PriceLabel.Visible = false;
                NameLabel.Visible = false;
                AmountLabel.Visible = false;
                SilverTextBox.Visible = false;
                SilverLabel.Visible = false;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                ItemBox1_0.Visible = true;
                ItemBox1_1.Visible = true;
                ItemBox1_2.Visible = true;
                ItemBox2_0.Visible = true;
                ItemBox2_1.Visible = true;
                ItemBox2_2.Visible = true;
                ItemBox3_0.Visible = true;
                ItemBox3_1.Visible = true;
                ItemBox3_2.Visible = true;
                ItemBox4_0.Visible = true;
                ItemBox4_1.Visible = true;
                ItemBox4_2.Visible = true;
                ItemBox5_0.Visible = true;
                ItemBox5_1.Visible = true;
                ItemBox5_2.Visible = true;
                PriceLabel.Visible = true;
                NameLabel.Visible = true;
                AmountLabel.Visible = true;
                SilverTextBox.Visible = true;
                SilverLabel.Visible = true;
            }
            else
            {
                ItemBox1_0.Visible = false;
                ItemBox1_1.Visible = false;
                ItemBox1_2.Visible = false;
                ItemBox2_0.Visible = false;
                ItemBox2_1.Visible = false;
                ItemBox2_2.Visible = false;
                ItemBox3_0.Visible = false;
                ItemBox3_1.Visible = false;
                ItemBox3_2.Visible = false;
                ItemBox4_0.Visible = false;
                ItemBox4_1.Visible = false;
                ItemBox4_2.Visible = false;
                ItemBox5_0.Visible = false;
                ItemBox5_1.Visible = false;
                ItemBox5_2.Visible = false;
                PriceLabel.Visible = false;
                NameLabel.Visible = false;
                AmountLabel.Visible = false;
                SilverTextBox.Visible = false;
                SilverLabel.Visible = false;
            }
        }

        private void CalcStartButton_Click(object sender, EventArgs e)
        {
            if ((radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked || radioButton5.Checked) 
                && (!(string.IsNullOrEmpty(SilverTextBox.Text)))) {

                int FirstItemValue = 0;
                int SecondItemValue = 0;
                int ThirdItemValue = 0;
                int FourthItemValue = 0;
                int FifthItemValue = 0;
                int SilverValue = int.Parse(SilverTextBox.Text);
                int EndValue = 0;
                if (radioButton1.Checked && !(string.IsNullOrEmpty(ItemBox1_1.Text)) && !((string.IsNullOrEmpty(ItemBox1_2.Text))))
                {
                    FirstItemValue = int.Parse(ItemBox1_1.Text) * int.Parse(ItemBox1_2.Text);
                    EndValue = FirstItemValue + SilverValue;
                    ValueLabel.Text = EndValue.ToString() + " -";
                    ValueLabel.Visible = true;
                    SellPriceLabel.Visible = true;
                    SellPriceTextBox.Visible = true;
                    PremiumAndTaxListBox.Visible = true;
                    CalcSellPriceButton.Visible = true;
                }
                else if (radioButton2.Checked && !(string.IsNullOrEmpty(ItemBox1_1.Text)) && !((string.IsNullOrEmpty(ItemBox1_2.Text)))
                    && !(string.IsNullOrEmpty(ItemBox2_1.Text)) && !((string.IsNullOrEmpty(ItemBox2_2.Text))))
                {
                    FirstItemValue = int.Parse(ItemBox1_1.Text) * int.Parse(ItemBox1_2.Text);
                    SecondItemValue = int.Parse(ItemBox2_1.Text) * int.Parse(ItemBox2_2.Text);
                    EndValue = FirstItemValue + SecondItemValue + SilverValue;
                    ValueLabel.Text = EndValue.ToString() + " -";
                    ValueLabel.Visible = true;
                    SellPriceLabel.Visible = true;
                    SellPriceTextBox.Visible = true;
                    PremiumAndTaxListBox.Visible = true;
                    CalcSellPriceButton.Visible = true;
                }
                else if (radioButton3.Checked && !(string.IsNullOrEmpty(ItemBox1_1.Text)) && !((string.IsNullOrEmpty(ItemBox1_2.Text)))
                    && !(string.IsNullOrEmpty(ItemBox2_1.Text)) && !((string.IsNullOrEmpty(ItemBox2_2.Text)))
                    && !(string.IsNullOrEmpty(ItemBox3_1.Text)) && !((string.IsNullOrEmpty(ItemBox3_2.Text)))
                    )
                {
                    FirstItemValue = int.Parse(ItemBox1_1.Text) * int.Parse(ItemBox1_2.Text);
                    SecondItemValue = int.Parse(ItemBox2_1.Text) * int.Parse(ItemBox2_2.Text);
                    ThirdItemValue = int.Parse(ItemBox3_1.Text) * int.Parse(ItemBox3_2.Text);
                    EndValue = FirstItemValue + SecondItemValue + ThirdItemValue + SilverValue;
                    ValueLabel.Text = EndValue.ToString() + " -";
                    ValueLabel.Visible = true;
                    SellPriceLabel.Visible = true;
                    SellPriceTextBox.Visible = true;
                    PremiumAndTaxListBox.Visible = true;
                    CalcSellPriceButton.Visible = true;
                }
                else if (radioButton4.Checked && !(string.IsNullOrEmpty(ItemBox1_1.Text)) && !((string.IsNullOrEmpty(ItemBox1_2.Text)))
                    && !(string.IsNullOrEmpty(ItemBox2_1.Text)) && !((string.IsNullOrEmpty(ItemBox2_2.Text)))
                    && !(string.IsNullOrEmpty(ItemBox3_1.Text)) && !((string.IsNullOrEmpty(ItemBox3_2.Text)))
                    && !(string.IsNullOrEmpty(ItemBox4_1.Text)) && !((string.IsNullOrEmpty(ItemBox4_2.Text)))
                    )
                {
                    FirstItemValue = int.Parse(ItemBox1_1.Text) * int.Parse(ItemBox1_2.Text);
                    SecondItemValue = int.Parse(ItemBox2_1.Text) * int.Parse(ItemBox2_2.Text);
                    ThirdItemValue = int.Parse(ItemBox3_1.Text) * int.Parse(ItemBox3_2.Text);
                    FourthItemValue = int.Parse(ItemBox4_1.Text) * int.Parse(ItemBox4_2.Text);
                    EndValue = FirstItemValue + SecondItemValue + ThirdItemValue + FourthItemValue + int.Parse(SilverTextBox.Text);
                    ValueLabel.Text = EndValue.ToString() + " -";
                    ValueLabel.Visible = true;
                    SellPriceLabel.Visible = true;
                    SellPriceTextBox.Visible = true;
                    PremiumAndTaxListBox.Visible = true;
                    CalcSellPriceButton.Visible = true;
                }
                else if (radioButton5.Checked && !(string.IsNullOrEmpty(ItemBox1_1.Text)) && !((string.IsNullOrEmpty(ItemBox1_2.Text)))
                    && !(string.IsNullOrEmpty(ItemBox2_1.Text)) && !((string.IsNullOrEmpty(ItemBox2_2.Text)))
                    && !(string.IsNullOrEmpty(ItemBox3_1.Text)) && !((string.IsNullOrEmpty(ItemBox3_2.Text)))
                    && !(string.IsNullOrEmpty(ItemBox4_1.Text)) && !((string.IsNullOrEmpty(ItemBox4_2.Text)))
                    && !(string.IsNullOrEmpty(ItemBox5_1.Text)) && !((string.IsNullOrEmpty(ItemBox5_2.Text)))
                    )
                {
                    FirstItemValue = int.Parse(ItemBox1_1.Text) * int.Parse(ItemBox1_2.Text);
                    SecondItemValue = int.Parse(ItemBox2_1.Text) * int.Parse(ItemBox2_2.Text);
                    ThirdItemValue = int.Parse(ItemBox3_1.Text) * int.Parse(ItemBox3_2.Text);
                    FourthItemValue = int.Parse(ItemBox4_1.Text) * int.Parse(ItemBox4_2.Text);
                    FifthItemValue = int.Parse(ItemBox5_1.Text) * int.Parse(ItemBox5_2.Text);
                    EndValue = FirstItemValue + SecondItemValue + ThirdItemValue + FourthItemValue + FifthItemValue + int.Parse(SilverTextBox.Text);
                    ValueLabel.Text = EndValue.ToString() + " -" ;
                    ValueLabel.Visible = true;
                    SellPriceLabel.Visible = true;
                    SellPriceTextBox.Visible = true;
                    PremiumAndTaxListBox.Visible = true;
                    CalcSellPriceButton.Visible = true;
                }
                else {
                    MessageBox.Show("Value in text box is empty!", "Check text boxes!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            else
            {
                MessageBox.Show("None of checkbox is checked! Or value in text box is empty!", "Check one of checkboxs or text boxes!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcSellPriceButton_Click(object sender, EventArgs e)
        {
            //premium index 0
            //sell tax index 1
            if (!(string.IsNullOrEmpty(SellPriceTextBox.Text)))
            {

                EndCalcValueLabel.Visible = true;
                EndPriceLabel.Visible = true;
                int CraftPrice = int.Parse(ValueLabel.Text.ToString().Replace("-", ""));
                int SellPrice = int.Parse(SellPriceTextBox.Text);

                if (PremiumAndTaxListBox.GetItemChecked(0) && PremiumAndTaxListBox.GetItemChecked(1))
                {
                    EndCalcValueLabel.Text = ((SellPrice * 0.96 * 0.975) - CraftPrice).ToString();
                }
                else if (PremiumAndTaxListBox.GetItemChecked(0))
                {
                    EndCalcValueLabel.Text = ((SellPrice * 0.96) - CraftPrice).ToString();
                }
                else if (PremiumAndTaxListBox.GetItemChecked(1))
                {
                    EndCalcValueLabel.Text = ((SellPrice * 0.92 *0.975) - CraftPrice).ToString();
                }
                else
                {
                    EndCalcValueLabel.Text = ((SellPrice * 0.92) - CraftPrice).ToString();
                }
            }
            else
            {
                MessageBox.Show("Sell price text box is empty!", "Insert sell price to text box!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

