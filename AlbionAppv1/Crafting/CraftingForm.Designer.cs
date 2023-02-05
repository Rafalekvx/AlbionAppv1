namespace AlbionAppv1.Crafting
{
    partial class CraftingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackToMenuButton = new System.Windows.Forms.Button();
            this.HowManyItems = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.ItemBox1_0 = new System.Windows.Forms.TextBox();
            this.ItemBox1_1 = new System.Windows.Forms.TextBox();
            this.ItemBox2_1 = new System.Windows.Forms.TextBox();
            this.ItemBox2_0 = new System.Windows.Forms.TextBox();
            this.ItemBox3_0 = new System.Windows.Forms.TextBox();
            this.ItemBox3_1 = new System.Windows.Forms.TextBox();
            this.ItemBox4_0 = new System.Windows.Forms.TextBox();
            this.ItemBox4_1 = new System.Windows.Forms.TextBox();
            this.ItemBox5_0 = new System.Windows.Forms.TextBox();
            this.ItemBox5_1 = new System.Windows.Forms.TextBox();
            this.ItemBox1_2 = new System.Windows.Forms.TextBox();
            this.ItemBox2_2 = new System.Windows.Forms.TextBox();
            this.ItemBox3_2 = new System.Windows.Forms.TextBox();
            this.ItemBox4_2 = new System.Windows.Forms.TextBox();
            this.ItemBox5_2 = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.SilverTextBox = new System.Windows.Forms.TextBox();
            this.SilverLabel = new System.Windows.Forms.Label();
            this.CalcStartButton = new System.Windows.Forms.Button();
            this.SellPriceTextBox = new System.Windows.Forms.TextBox();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.EndCalcValueLabel = new System.Windows.Forms.Label();
            this.SellPriceLabel = new System.Windows.Forms.Label();
            this.EndPriceLabel = new System.Windows.Forms.Label();
            this.PremiumAndTaxListBox = new System.Windows.Forms.CheckedListBox();
            this.CalcSellPriceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackToMenuButton
            // 
            this.BackToMenuButton.Location = new System.Drawing.Point(621, 12);
            this.BackToMenuButton.Name = "BackToMenuButton";
            this.BackToMenuButton.Size = new System.Drawing.Size(167, 79);
            this.BackToMenuButton.TabIndex = 0;
            this.BackToMenuButton.Text = "Back to menu";
            this.BackToMenuButton.UseVisualStyleBackColor = true;
            this.BackToMenuButton.Click += new System.EventHandler(this.BackToMenuButton_Click);
            // 
            // HowManyItems
            // 
            this.HowManyItems.AutoSize = true;
            this.HowManyItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HowManyItems.Location = new System.Drawing.Point(39, 23);
            this.HowManyItems.Name = "HowManyItems";
            this.HowManyItems.Size = new System.Drawing.Size(498, 25);
            this.HowManyItems.TabIndex = 1;
            this.HowManyItems.Text = "How many items is needed to craft? (without silver)";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(26, 74);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1 Item";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(141, 74);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2 Items";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(258, 74);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(59, 17);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3 Items";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(367, 74);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(59, 17);
            this.radioButton4.TabIndex = 5;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "4 Items";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(469, 74);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(59, 17);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "5 Items";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // ItemBox1_0
            // 
            this.ItemBox1_0.Location = new System.Drawing.Point(12, 166);
            this.ItemBox1_0.Name = "ItemBox1_0";
            this.ItemBox1_0.Size = new System.Drawing.Size(100, 20);
            this.ItemBox1_0.TabIndex = 7;
            this.ItemBox1_0.Visible = false;
            // 
            // ItemBox1_1
            // 
            this.ItemBox1_1.Location = new System.Drawing.Point(141, 166);
            this.ItemBox1_1.Name = "ItemBox1_1";
            this.ItemBox1_1.Size = new System.Drawing.Size(100, 20);
            this.ItemBox1_1.TabIndex = 8;
            this.ItemBox1_1.Visible = false;
            // 
            // ItemBox2_1
            // 
            this.ItemBox2_1.Location = new System.Drawing.Point(141, 202);
            this.ItemBox2_1.Name = "ItemBox2_1";
            this.ItemBox2_1.Size = new System.Drawing.Size(100, 20);
            this.ItemBox2_1.TabIndex = 9;
            this.ItemBox2_1.Visible = false;
            // 
            // ItemBox2_0
            // 
            this.ItemBox2_0.Location = new System.Drawing.Point(12, 202);
            this.ItemBox2_0.Name = "ItemBox2_0";
            this.ItemBox2_0.Size = new System.Drawing.Size(100, 20);
            this.ItemBox2_0.TabIndex = 10;
            this.ItemBox2_0.Visible = false;
            // 
            // ItemBox3_0
            // 
            this.ItemBox3_0.Location = new System.Drawing.Point(12, 239);
            this.ItemBox3_0.Name = "ItemBox3_0";
            this.ItemBox3_0.Size = new System.Drawing.Size(100, 20);
            this.ItemBox3_0.TabIndex = 11;
            this.ItemBox3_0.Visible = false;
            // 
            // ItemBox3_1
            // 
            this.ItemBox3_1.Location = new System.Drawing.Point(141, 239);
            this.ItemBox3_1.Name = "ItemBox3_1";
            this.ItemBox3_1.Size = new System.Drawing.Size(100, 20);
            this.ItemBox3_1.TabIndex = 25;
            this.ItemBox3_1.Visible = false;
            // 
            // ItemBox4_0
            // 
            this.ItemBox4_0.Location = new System.Drawing.Point(12, 281);
            this.ItemBox4_0.Name = "ItemBox4_0";
            this.ItemBox4_0.Size = new System.Drawing.Size(100, 20);
            this.ItemBox4_0.TabIndex = 13;
            this.ItemBox4_0.Visible = false;
            // 
            // ItemBox4_1
            // 
            this.ItemBox4_1.Location = new System.Drawing.Point(141, 281);
            this.ItemBox4_1.Name = "ItemBox4_1";
            this.ItemBox4_1.Size = new System.Drawing.Size(100, 20);
            this.ItemBox4_1.TabIndex = 14;
            this.ItemBox4_1.Visible = false;
            // 
            // ItemBox5_0
            // 
            this.ItemBox5_0.Location = new System.Drawing.Point(12, 319);
            this.ItemBox5_0.Name = "ItemBox5_0";
            this.ItemBox5_0.Size = new System.Drawing.Size(100, 20);
            this.ItemBox5_0.TabIndex = 15;
            this.ItemBox5_0.Visible = false;
            // 
            // ItemBox5_1
            // 
            this.ItemBox5_1.Location = new System.Drawing.Point(141, 319);
            this.ItemBox5_1.Name = "ItemBox5_1";
            this.ItemBox5_1.Size = new System.Drawing.Size(100, 20);
            this.ItemBox5_1.TabIndex = 16;
            this.ItemBox5_1.Visible = false;
            // 
            // ItemBox1_2
            // 
            this.ItemBox1_2.Location = new System.Drawing.Point(268, 166);
            this.ItemBox1_2.Name = "ItemBox1_2";
            this.ItemBox1_2.Size = new System.Drawing.Size(100, 20);
            this.ItemBox1_2.TabIndex = 17;
            this.ItemBox1_2.Visible = false;
            // 
            // ItemBox2_2
            // 
            this.ItemBox2_2.Location = new System.Drawing.Point(268, 202);
            this.ItemBox2_2.Name = "ItemBox2_2";
            this.ItemBox2_2.Size = new System.Drawing.Size(100, 20);
            this.ItemBox2_2.TabIndex = 18;
            this.ItemBox2_2.Visible = false;
            // 
            // ItemBox3_2
            // 
            this.ItemBox3_2.Location = new System.Drawing.Point(268, 239);
            this.ItemBox3_2.Name = "ItemBox3_2";
            this.ItemBox3_2.Size = new System.Drawing.Size(100, 20);
            this.ItemBox3_2.TabIndex = 19;
            this.ItemBox3_2.Visible = false;
            // 
            // ItemBox4_2
            // 
            this.ItemBox4_2.Location = new System.Drawing.Point(268, 281);
            this.ItemBox4_2.Name = "ItemBox4_2";
            this.ItemBox4_2.Size = new System.Drawing.Size(100, 20);
            this.ItemBox4_2.TabIndex = 20;
            this.ItemBox4_2.Visible = false;
            // 
            // ItemBox5_2
            // 
            this.ItemBox5_2.Location = new System.Drawing.Point(268, 319);
            this.ItemBox5_2.Name = "ItemBox5_2";
            this.ItemBox5_2.Size = new System.Drawing.Size(100, 20);
            this.ItemBox5_2.TabIndex = 21;
            this.ItemBox5_2.Visible = false;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PriceLabel.Location = new System.Drawing.Point(289, 123);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(61, 25);
            this.PriceLabel.TabIndex = 22;
            this.PriceLabel.Text = "Price";
            this.PriceLabel.Visible = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameLabel.Location = new System.Drawing.Point(9, 130);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(118, 15);
            this.NameLabel.TabIndex = 23;
            this.NameLabel.Text = "Name (not required)";
            this.NameLabel.Visible = false;
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AmountLabel.Location = new System.Drawing.Point(147, 123);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(85, 25);
            this.AmountLabel.TabIndex = 24;
            this.AmountLabel.Text = "Amount";
            this.AmountLabel.Visible = false;
            // 
            // SilverTextBox
            // 
            this.SilverTextBox.Location = new System.Drawing.Point(163, 383);
            this.SilverTextBox.Name = "SilverTextBox";
            this.SilverTextBox.Size = new System.Drawing.Size(100, 20);
            this.SilverTextBox.TabIndex = 26;
            this.SilverTextBox.Visible = false;
            // 
            // SilverLabel
            // 
            this.SilverLabel.AutoSize = true;
            this.SilverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SilverLabel.Location = new System.Drawing.Point(73, 383);
            this.SilverLabel.Name = "SilverLabel";
            this.SilverLabel.Size = new System.Drawing.Size(84, 20);
            this.SilverLabel.TabIndex = 27;
            this.SilverLabel.Text = "Silver Cost";
            this.SilverLabel.Visible = false;
            // 
            // CalcStartButton
            // 
            this.CalcStartButton.Location = new System.Drawing.Point(528, 324);
            this.CalcStartButton.Name = "CalcStartButton";
            this.CalcStartButton.Size = new System.Drawing.Size(167, 79);
            this.CalcStartButton.TabIndex = 28;
            this.CalcStartButton.Text = "Calculate!";
            this.CalcStartButton.UseVisualStyleBackColor = true;
            this.CalcStartButton.Click += new System.EventHandler(this.CalcStartButton_Click);
            // 
            // SellPriceTextBox
            // 
            this.SellPriceTextBox.Location = new System.Drawing.Point(528, 188);
            this.SellPriceTextBox.Name = "SellPriceTextBox";
            this.SellPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.SellPriceTextBox.TabIndex = 30;
            this.SellPriceTextBox.Visible = false;
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(476, 191);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(35, 13);
            this.ValueLabel.TabIndex = 31;
            this.ValueLabel.Text = "label6";
            this.ValueLabel.Visible = false;
            // 
            // EndCalcValueLabel
            // 
            this.EndCalcValueLabel.AutoSize = true;
            this.EndCalcValueLabel.Location = new System.Drawing.Point(683, 191);
            this.EndCalcValueLabel.Name = "EndCalcValueLabel";
            this.EndCalcValueLabel.Size = new System.Drawing.Size(35, 13);
            this.EndCalcValueLabel.TabIndex = 32;
            this.EndCalcValueLabel.Text = "label5";
            this.EndCalcValueLabel.Visible = false;
            // 
            // SellPriceLabel
            // 
            this.SellPriceLabel.AutoSize = true;
            this.SellPriceLabel.Location = new System.Drawing.Point(557, 166);
            this.SellPriceLabel.Name = "SellPriceLabel";
            this.SellPriceLabel.Size = new System.Drawing.Size(51, 13);
            this.SellPriceLabel.TabIndex = 33;
            this.SellPriceLabel.Text = "Sell Price";
            this.SellPriceLabel.Visible = false;
            // 
            // EndPriceLabel
            // 
            this.EndPriceLabel.AutoSize = true;
            this.EndPriceLabel.Location = new System.Drawing.Point(683, 166);
            this.EndPriceLabel.Name = "EndPriceLabel";
            this.EndPriceLabel.Size = new System.Drawing.Size(53, 13);
            this.EndPriceLabel.TabIndex = 34;
            this.EndPriceLabel.Text = "End Price";
            this.EndPriceLabel.Visible = false;
            // 
            // PremiumAndTaxListBox
            // 
            this.PremiumAndTaxListBox.FormattingEnabled = true;
            this.PremiumAndTaxListBox.Items.AddRange(new object[] {
            "Premium",
            "Sell Tax"});
            this.PremiumAndTaxListBox.Location = new System.Drawing.Point(686, 239);
            this.PremiumAndTaxListBox.Name = "PremiumAndTaxListBox";
            this.PremiumAndTaxListBox.Size = new System.Drawing.Size(77, 34);
            this.PremiumAndTaxListBox.TabIndex = 35;
            this.PremiumAndTaxListBox.Visible = false;
            // 
            // CalcSellPriceButton
            // 
            this.CalcSellPriceButton.AllowDrop = true;
            this.CalcSellPriceButton.Location = new System.Drawing.Point(528, 239);
            this.CalcSellPriceButton.Name = "CalcSellPriceButton";
            this.CalcSellPriceButton.Size = new System.Drawing.Size(100, 34);
            this.CalcSellPriceButton.TabIndex = 36;
            this.CalcSellPriceButton.Text = "Calculate Sell Price";
            this.CalcSellPriceButton.UseVisualStyleBackColor = true;
            this.CalcSellPriceButton.Visible = false;
            this.CalcSellPriceButton.Click += new System.EventHandler(this.CalcSellPriceButton_Click);
            // 
            // CraftingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalcSellPriceButton);
            this.Controls.Add(this.PremiumAndTaxListBox);
            this.Controls.Add(this.EndPriceLabel);
            this.Controls.Add(this.SellPriceLabel);
            this.Controls.Add(this.EndCalcValueLabel);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.SellPriceTextBox);
            this.Controls.Add(this.CalcStartButton);
            this.Controls.Add(this.SilverLabel);
            this.Controls.Add(this.SilverTextBox);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ItemBox5_2);
            this.Controls.Add(this.ItemBox4_2);
            this.Controls.Add(this.ItemBox3_2);
            this.Controls.Add(this.ItemBox2_2);
            this.Controls.Add(this.ItemBox1_2);
            this.Controls.Add(this.ItemBox5_1);
            this.Controls.Add(this.ItemBox5_0);
            this.Controls.Add(this.ItemBox4_1);
            this.Controls.Add(this.ItemBox4_0);
            this.Controls.Add(this.ItemBox3_1);
            this.Controls.Add(this.ItemBox3_0);
            this.Controls.Add(this.ItemBox2_0);
            this.Controls.Add(this.ItemBox2_1);
            this.Controls.Add(this.ItemBox1_1);
            this.Controls.Add(this.ItemBox1_0);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.HowManyItems);
            this.Controls.Add(this.BackToMenuButton);
            this.Name = "CraftingForm";
            this.Text = "CraftingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToMenuButton;
        private System.Windows.Forms.Label HowManyItems;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.TextBox ItemBox1_0;
        private System.Windows.Forms.TextBox ItemBox1_1;
        private System.Windows.Forms.TextBox ItemBox2_1;
        private System.Windows.Forms.TextBox ItemBox2_0;
        private System.Windows.Forms.TextBox ItemBox3_0;
        private System.Windows.Forms.TextBox ItemBox3_1;
        private System.Windows.Forms.TextBox ItemBox4_0;
        private System.Windows.Forms.TextBox ItemBox4_1;
        private System.Windows.Forms.TextBox ItemBox5_0;
        private System.Windows.Forms.TextBox ItemBox5_1;
        private System.Windows.Forms.TextBox ItemBox1_2;
        private System.Windows.Forms.TextBox ItemBox2_2;
        private System.Windows.Forms.TextBox ItemBox3_2;
        private System.Windows.Forms.TextBox ItemBox4_2;
        private System.Windows.Forms.TextBox ItemBox5_2;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.TextBox SilverTextBox;
        private System.Windows.Forms.Label SilverLabel;
        private System.Windows.Forms.Button CalcStartButton;
        private System.Windows.Forms.TextBox SellPriceTextBox;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label EndCalcValueLabel;
        private System.Windows.Forms.Label SellPriceLabel;
        private System.Windows.Forms.Label EndPriceLabel;
        private System.Windows.Forms.CheckedListBox PremiumAndTaxListBox;
        private System.Windows.Forms.Button CalcSellPriceButton;
    }
}