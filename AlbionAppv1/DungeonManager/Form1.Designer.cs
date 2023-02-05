namespace AlbionAppv1
{
    partial class Form1
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
            this.getButton = new System.Windows.Forms.Button();
            this.albiondatav1 = new System.Windows.Forms.DataGridView();
            this.starterButton = new System.Windows.Forms.Button();
            this.BackToMenuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.albiondatav1)).BeginInit();
            this.SuspendLayout();
            // 
            // getButton
            // 
            this.getButton.Location = new System.Drawing.Point(532, 38);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(211, 86);
            this.getButton.TabIndex = 0;
            this.getButton.Text = "Get data";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // albiondatav1
            // 
            this.albiondatav1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.albiondatav1.Location = new System.Drawing.Point(12, 181);
            this.albiondatav1.Name = "albiondatav1";
            this.albiondatav1.Size = new System.Drawing.Size(776, 257);
            this.albiondatav1.TabIndex = 1;
            // 
            // starterButton
            // 
            this.starterButton.Location = new System.Drawing.Point(31, 38);
            this.starterButton.Name = "starterButton";
            this.starterButton.Size = new System.Drawing.Size(194, 86);
            this.starterButton.TabIndex = 2;
            this.starterButton.Text = "Start run";
            this.starterButton.UseVisualStyleBackColor = true;
            this.starterButton.Click += new System.EventHandler(this.starterButton_Click);
            // 
            // BackToMenuButton
            // 
            this.BackToMenuButton.Location = new System.Drawing.Point(277, 38);
            this.BackToMenuButton.Name = "BackToMenuButton";
            this.BackToMenuButton.Size = new System.Drawing.Size(194, 86);
            this.BackToMenuButton.TabIndex = 3;
            this.BackToMenuButton.Text = "Back to menu";
            this.BackToMenuButton.UseVisualStyleBackColor = true;
            this.BackToMenuButton.Click += new System.EventHandler(this.BackToMenuButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackToMenuButton);
            this.Controls.Add(this.starterButton);
            this.Controls.Add(this.albiondatav1);
            this.Controls.Add(this.getButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.albiondatav1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.DataGridView albiondatav1;
        private System.Windows.Forms.Button starterButton;
        private System.Windows.Forms.Button BackToMenuButton;
    }
}

