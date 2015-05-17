namespace Lab_TDD
{
    partial class NewGamer
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
            this.label_gamer = new System.Windows.Forms.Label();
            this.numericUpDown_gamers = new System.Windows.Forms.NumericUpDown();
            this.label_N_gamer = new System.Windows.Forms.Label();
            this.label_num_gamer = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name_gamer = new System.Windows.Forms.Label();
            this.button_dalee = new System.Windows.Forms.Button();
            this.button_kol_gamer = new System.Windows.Forms.Button();
            this.panel_dan_gamer = new System.Windows.Forms.Panel();
            this.panel_kol_gamer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_gamers)).BeginInit();
            this.panel_dan_gamer.SuspendLayout();
            this.panel_kol_gamer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_gamer
            // 
            this.label_gamer.AutoSize = true;
            this.label_gamer.Location = new System.Drawing.Point(3, 18);
            this.label_gamer.Name = "label_gamer";
            this.label_gamer.Size = new System.Drawing.Size(116, 13);
            this.label_gamer.TabIndex = 0;
            this.label_gamer.Text = "Количество игроков: ";
            // 
            // numericUpDown_gamers
            // 
            this.numericUpDown_gamers.Location = new System.Drawing.Point(125, 11);
            this.numericUpDown_gamers.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_gamers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_gamers.Name = "numericUpDown_gamers";
            this.numericUpDown_gamers.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_gamers.TabIndex = 1;
            this.numericUpDown_gamers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_N_gamer
            // 
            this.label_N_gamer.AutoSize = true;
            this.label_N_gamer.Location = new System.Drawing.Point(3, 13);
            this.label_N_gamer.Name = "label_N_gamer";
            this.label_N_gamer.Size = new System.Drawing.Size(154, 13);
            this.label_N_gamer.TabIndex = 2;
            this.label_N_gamer.Text = "Заполните данные игрока №";
            // 
            // label_num_gamer
            // 
            this.label_num_gamer.AutoSize = true;
            this.label_num_gamer.Location = new System.Drawing.Point(163, 13);
            this.label_num_gamer.Name = "label_num_gamer";
            this.label_num_gamer.Size = new System.Drawing.Size(13, 13);
            this.label_num_gamer.TabIndex = 3;
            this.label_num_gamer.Text = "0";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(76, 44);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(255, 20);
            this.textBox_name.TabIndex = 4;
            // 
            // label_name_gamer
            // 
            this.label_name_gamer.AutoSize = true;
            this.label_name_gamer.Location = new System.Drawing.Point(3, 47);
            this.label_name_gamer.Name = "label_name_gamer";
            this.label_name_gamer.Size = new System.Drawing.Size(67, 13);
            this.label_name_gamer.TabIndex = 5;
            this.label_name_gamer.Text = "Имя игрока";
            // 
            // button_dalee
            // 
            this.button_dalee.Location = new System.Drawing.Point(256, 70);
            this.button_dalee.Name = "button_dalee";
            this.button_dalee.Size = new System.Drawing.Size(75, 23);
            this.button_dalee.TabIndex = 6;
            this.button_dalee.Text = "Далее";
            this.button_dalee.UseVisualStyleBackColor = true;
            this.button_dalee.Click += new System.EventHandler(this.button_dalee_Click);
            // 
            // button_kol_gamer
            // 
            this.button_kol_gamer.Location = new System.Drawing.Point(262, 11);
            this.button_kol_gamer.Name = "button_kol_gamer";
            this.button_kol_gamer.Size = new System.Drawing.Size(75, 23);
            this.button_kol_gamer.TabIndex = 7;
            this.button_kol_gamer.Text = "Ввести";
            this.button_kol_gamer.UseVisualStyleBackColor = true;
            this.button_kol_gamer.Click += new System.EventHandler(this.button_kol_gamer_Click);
            // 
            // panel_dan_gamer
            // 
            this.panel_dan_gamer.Controls.Add(this.label_N_gamer);
            this.panel_dan_gamer.Controls.Add(this.label_num_gamer);
            this.panel_dan_gamer.Controls.Add(this.button_dalee);
            this.panel_dan_gamer.Controls.Add(this.textBox_name);
            this.panel_dan_gamer.Controls.Add(this.label_name_gamer);
            this.panel_dan_gamer.Enabled = false;
            this.panel_dan_gamer.Location = new System.Drawing.Point(12, 83);
            this.panel_dan_gamer.Name = "panel_dan_gamer";
            this.panel_dan_gamer.Size = new System.Drawing.Size(346, 105);
            this.panel_dan_gamer.TabIndex = 8;
            // 
            // panel_kol_gamer
            // 
            this.panel_kol_gamer.Controls.Add(this.label_gamer);
            this.panel_kol_gamer.Controls.Add(this.numericUpDown_gamers);
            this.panel_kol_gamer.Controls.Add(this.button_kol_gamer);
            this.panel_kol_gamer.Location = new System.Drawing.Point(12, 12);
            this.panel_kol_gamer.Name = "panel_kol_gamer";
            this.panel_kol_gamer.Size = new System.Drawing.Size(346, 47);
            this.panel_kol_gamer.TabIndex = 9;
            // 
            // NewGamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 208);
            this.Controls.Add(this.panel_kol_gamer);
            this.Controls.Add(this.panel_dan_gamer);
            this.Name = "NewGamer";
            this.Text = "NewGamer";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_gamers)).EndInit();
            this.panel_dan_gamer.ResumeLayout(false);
            this.panel_dan_gamer.PerformLayout();
            this.panel_kol_gamer.ResumeLayout(false);
            this.panel_kol_gamer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_gamer;
        private System.Windows.Forms.NumericUpDown numericUpDown_gamers;
        private System.Windows.Forms.Label label_N_gamer;
        private System.Windows.Forms.Label label_num_gamer;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_name_gamer;
        private System.Windows.Forms.Button button_dalee;
        private System.Windows.Forms.Button button_kol_gamer;
        private System.Windows.Forms.Panel panel_dan_gamer;
        private System.Windows.Forms.Panel panel_kol_gamer;
    }
}