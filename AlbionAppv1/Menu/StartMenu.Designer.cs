namespace AlbionAppv1.Menu
{
    partial class StartMenu
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.DungeonButton = new System.Windows.Forms.Button();
            this.CraftingButton = new System.Windows.Forms.Button();
            this.DatabaseButton = new System.Windows.Forms.Button();
            this.TradeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(564, 73);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(177, 87);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Quit Program";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DungeonButton
            // 
            this.DungeonButton.Location = new System.Drawing.Point(71, 73);
            this.DungeonButton.Name = "DungeonButton";
            this.DungeonButton.Size = new System.Drawing.Size(177, 87);
            this.DungeonButton.TabIndex = 1;
            this.DungeonButton.Text = "Dungeon Manager";
            this.DungeonButton.UseVisualStyleBackColor = true;
            this.DungeonButton.Click += new System.EventHandler(this.DungeonButton_Click);
            // 
            // CraftingButton
            // 
            this.CraftingButton.Location = new System.Drawing.Point(310, 351);
            this.CraftingButton.Name = "CraftingButton";
            this.CraftingButton.Size = new System.Drawing.Size(177, 87);
            this.CraftingButton.TabIndex = 2;
            this.CraftingButton.Text = "Crafting Calculator";
            this.CraftingButton.UseVisualStyleBackColor = true;
            this.CraftingButton.Click += new System.EventHandler(this.CraftingButton_Click);
            // 
            // DatabaseButton
            // 
            this.DatabaseButton.Location = new System.Drawing.Point(12, 351);
            this.DatabaseButton.Name = "DatabaseButton";
            this.DatabaseButton.Size = new System.Drawing.Size(177, 87);
            this.DatabaseButton.TabIndex = 3;
            this.DatabaseButton.Text = "Items Database";
            this.DatabaseButton.UseVisualStyleBackColor = true;
            // 
            // TradeButton
            // 
            this.TradeButton.Location = new System.Drawing.Point(611, 351);
            this.TradeButton.Name = "TradeButton";
            this.TradeButton.Size = new System.Drawing.Size(177, 87);
            this.TradeButton.TabIndex = 4;
            this.TradeButton.Text = "Trade Calculator";
            this.TradeButton.UseVisualStyleBackColor = true;
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TradeButton);
            this.Controls.Add(this.DatabaseButton);
            this.Controls.Add(this.CraftingButton);
            this.Controls.Add(this.DungeonButton);
            this.Controls.Add(this.ExitButton);
            this.Name = "StartMenu";
            this.Text = "StartMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DungeonButton;
        private System.Windows.Forms.Button CraftingButton;
        private System.Windows.Forms.Button DatabaseButton;
        private System.Windows.Forms.Button TradeButton;
    }
}