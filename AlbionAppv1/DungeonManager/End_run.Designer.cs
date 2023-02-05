namespace AlbionAppv1
{
    partial class End_run
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
            this.label1 = new System.Windows.Forms.Label();
            this.endRunButton = new System.Windows.Forms.Button();
            this.newSilver = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newItemValue = new System.Windows.Forms.TextBox();
            this.endRunTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Silver Amount";
            // 
            // endRunButton
            // 
            this.endRunButton.Location = new System.Drawing.Point(337, 265);
            this.endRunButton.Name = "endRunButton";
            this.endRunButton.Size = new System.Drawing.Size(257, 59);
            this.endRunButton.TabIndex = 1;
            this.endRunButton.Text = "End run";
            this.endRunButton.UseVisualStyleBackColor = true;
            this.endRunButton.Click += new System.EventHandler(this.endRunButton_Click);
            // 
            // newSilver
            // 
            this.newSilver.Location = new System.Drawing.Point(244, 103);
            this.newSilver.Name = "newSilver";
            this.newSilver.Size = new System.Drawing.Size(100, 20);
            this.newSilver.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Item Value Amount";
            // 
            // newItemValue
            // 
            this.newItemValue.Location = new System.Drawing.Point(244, 189);
            this.newItemValue.Name = "newItemValue";
            this.newItemValue.Size = new System.Drawing.Size(100, 20);
            this.newItemValue.TabIndex = 6;
            // 
            // endRunTimePicker
            // 
            this.endRunTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endRunTimePicker.Location = new System.Drawing.Point(394, 39);
            this.endRunTimePicker.Name = "endRunTimePicker";
            this.endRunTimePicker.ShowUpDown = true;
            this.endRunTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endRunTimePicker.TabIndex = 7;
            // 
            // End_run
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 352);
            this.Controls.Add(this.endRunTimePicker);
            this.Controls.Add(this.newItemValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newSilver);
            this.Controls.Add(this.endRunButton);
            this.Controls.Add(this.label1);
            this.Name = "End_run";
            this.Text = "End_run";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button endRunButton;
        private System.Windows.Forms.TextBox newSilver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newItemValue;
        private System.Windows.Forms.DateTimePicker endRunTimePicker;
    }
}