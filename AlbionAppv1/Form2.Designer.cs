namespace AlbionAppv1
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tierBox = new System.Windows.Forms.TextBox();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.currentSilver = new System.Windows.Forms.TextBox();
            this.currentItemValue = new System.Windows.Forms.TextBox();
            this.mapCost = new System.Windows.Forms.TextBox();
            this.zone = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 84);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tier";
            // 
            // tierBox
            // 
            this.tierBox.Location = new System.Drawing.Point(191, 65);
            this.tierBox.Name = "tierBox";
            this.tierBox.Size = new System.Drawing.Size(100, 20);
            this.tierBox.TabIndex = 2;
            // 
            // startTimePicker
            // 
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTimePicker.Location = new System.Drawing.Point(457, 40);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(202, 20);
            this.startTimePicker.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Current Silver";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Current Item Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Map Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Zone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Type (solo/duo/group)";
            // 
            // currentSilver
            // 
            this.currentSilver.Location = new System.Drawing.Point(191, 108);
            this.currentSilver.Name = "currentSilver";
            this.currentSilver.Size = new System.Drawing.Size(100, 20);
            this.currentSilver.TabIndex = 9;
            // 
            // currentItemValue
            // 
            this.currentItemValue.Location = new System.Drawing.Point(191, 145);
            this.currentItemValue.Name = "currentItemValue";
            this.currentItemValue.Size = new System.Drawing.Size(100, 20);
            this.currentItemValue.TabIndex = 10;
            // 
            // mapCost
            // 
            this.mapCost.Location = new System.Drawing.Point(191, 180);
            this.mapCost.Name = "mapCost";
            this.mapCost.Size = new System.Drawing.Size(100, 20);
            this.mapCost.TabIndex = 11;
            // 
            // zone
            // 
            this.zone.Location = new System.Drawing.Point(191, 211);
            this.zone.Name = "zone";
            this.zone.Size = new System.Drawing.Size(100, 20);
            this.zone.TabIndex = 12;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(191, 252);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(100, 20);
            this.type.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.type);
            this.Controls.Add(this.zone);
            this.Controls.Add(this.mapCost);
            this.Controls.Add(this.currentItemValue);
            this.Controls.Add(this.currentSilver);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.tierBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tierBox;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox currentSilver;
        private System.Windows.Forms.TextBox currentItemValue;
        private System.Windows.Forms.TextBox mapCost;
        private System.Windows.Forms.TextBox zone;
        private System.Windows.Forms.TextBox type;
    }
}