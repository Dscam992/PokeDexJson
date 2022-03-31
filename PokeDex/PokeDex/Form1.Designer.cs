namespace PokeDex
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DescTB = new System.Windows.Forms.TextBox();
            this.HpTB = new System.Windows.Forms.TextBox();
            this.TypeTB = new System.Windows.Forms.TextBox();
            this.MoveTB = new System.Windows.Forms.TextBox();
            this.HeightTB = new System.Windows.Forms.TextBox();
            this.WeightTB = new System.Windows.Forms.TextBox();
            this.PicturePB = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pokemonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.FirstButton = new System.Windows.Forms.Button();
            this.LastButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePB)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Move:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Desc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pic:";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(91, 77);
            this.NameTB.Multiline = true;
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(100, 20);
            this.NameTB.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Height (ft):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Weight (lbs):";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // DescTB
            // 
            this.DescTB.Location = new System.Drawing.Point(280, 233);
            this.DescTB.Multiline = true;
            this.DescTB.Name = "DescTB";
            this.DescTB.Size = new System.Drawing.Size(206, 105);
            this.DescTB.TabIndex = 17;
            // 
            // HpTB
            // 
            this.HpTB.Location = new System.Drawing.Point(91, 162);
            this.HpTB.Name = "HpTB";
            this.HpTB.Size = new System.Drawing.Size(100, 20);
            this.HpTB.TabIndex = 12;
            // 
            // TypeTB
            // 
            this.TypeTB.Location = new System.Drawing.Point(91, 100);
            this.TypeTB.Name = "TypeTB";
            this.TypeTB.Size = new System.Drawing.Size(100, 20);
            this.TypeTB.TabIndex = 10;
            // 
            // MoveTB
            // 
            this.MoveTB.Location = new System.Drawing.Point(91, 131);
            this.MoveTB.Name = "MoveTB";
            this.MoveTB.Size = new System.Drawing.Size(100, 20);
            this.MoveTB.TabIndex = 11;
            // 
            // HeightTB
            // 
            this.HeightTB.Location = new System.Drawing.Point(91, 195);
            this.HeightTB.Name = "HeightTB";
            this.HeightTB.Size = new System.Drawing.Size(100, 20);
            this.HeightTB.TabIndex = 13;
            // 
            // WeightTB
            // 
            this.WeightTB.Location = new System.Drawing.Point(91, 226);
            this.WeightTB.Name = "WeightTB";
            this.WeightTB.Size = new System.Drawing.Size(100, 20);
            this.WeightTB.TabIndex = 14;
            // 
            // PicturePB
            // 
            this.PicturePB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicturePB.Location = new System.Drawing.Point(280, 77);
            this.PicturePB.Name = "PicturePB";
            this.PicturePB.Size = new System.Drawing.Size(206, 127);
            this.PicturePB.TabIndex = 16;
            this.PicturePB.TabStop = false;
            this.PicturePB.Click += new System.EventHandler(this.PicturePB_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokemonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pokemonToolStripMenuItem
            // 
            this.pokemonToolStripMenuItem.Name = "pokemonToolStripMenuItem";
            this.pokemonToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.pokemonToolStripMenuItem.Text = "Pokemon";
            this.pokemonToolStripMenuItem.Click += new System.EventHandler(this.pokemonToolStripMenuItem_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(524, 80);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddNewButton
            // 
            this.AddNewButton.Location = new System.Drawing.Point(524, 121);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(75, 23);
            this.AddNewButton.TabIndex = 16;
            this.AddNewButton.Text = "Add";
            this.AddNewButton.UseVisualStyleBackColor = true;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click_1);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(524, 157);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 18;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(524, 195);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 19;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(524, 315);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 20;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(524, 355);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(75, 23);
            this.PreviousButton.TabIndex = 21;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // FirstButton
            // 
            this.FirstButton.Location = new System.Drawing.Point(524, 233);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(75, 23);
            this.FirstButton.TabIndex = 22;
            this.FirstButton.Text = "First";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // LastButton
            // 
            this.LastButton.Location = new System.Drawing.Point(524, 276);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(75, 23);
            this.LastButton.TabIndex = 23;
            this.LastButton.Text = "Last";
            this.LastButton.UseVisualStyleBackColor = true;
            this.LastButton.Click += new System.EventHandler(this.LastButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(308, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 42);
            this.label9.TabIndex = 24;
            this.label9.Text = "PokeDex";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.LastButton);
            this.Controls.Add(this.FirstButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PicturePB);
            this.Controls.Add(this.WeightTB);
            this.Controls.Add(this.HeightTB);
            this.Controls.Add(this.MoveTB);
            this.Controls.Add(this.TypeTB);
            this.Controls.Add(this.HpTB);
            this.Controls.Add(this.DescTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "11";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicturePB)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DescTB;
        private System.Windows.Forms.TextBox HpTB;
        private System.Windows.Forms.TextBox TypeTB;
        private System.Windows.Forms.TextBox MoveTB;
        private System.Windows.Forms.TextBox HeightTB;
        private System.Windows.Forms.TextBox WeightTB;
        private System.Windows.Forms.PictureBox PicturePB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pokemonToolStripMenuItem;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.Label label9;
    }
}

