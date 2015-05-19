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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name_gamer = new System.Windows.Forms.Label();
            this.button_dalee = new System.Windows.Forms.Button();
            this.panel_dan_gamer = new System.Windows.Forms.Panel();
            this.panel_dan_gamer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(76, 8);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(255, 20);
            this.textBox_name.TabIndex = 4;
            // 
            // label_name_gamer
            // 
            this.label_name_gamer.AutoSize = true;
            this.label_name_gamer.Location = new System.Drawing.Point(3, 11);
            this.label_name_gamer.Name = "label_name_gamer";
            this.label_name_gamer.Size = new System.Drawing.Size(67, 13);
            this.label_name_gamer.TabIndex = 5;
            this.label_name_gamer.Text = "Имя игрока";
            // 
            // button_dalee
            // 
            this.button_dalee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_dalee.Location = new System.Drawing.Point(3, 34);
            this.button_dalee.Name = "button_dalee";
            this.button_dalee.Size = new System.Drawing.Size(340, 57);
            this.button_dalee.TabIndex = 6;
            this.button_dalee.Text = "Начать игру";
            this.button_dalee.UseVisualStyleBackColor = true;
            this.button_dalee.Click += new System.EventHandler(this.button_dalee_Click);
            // 
            // panel_dan_gamer
            // 
            this.panel_dan_gamer.Controls.Add(this.button_dalee);
            this.panel_dan_gamer.Controls.Add(this.textBox_name);
            this.panel_dan_gamer.Controls.Add(this.label_name_gamer);
            this.panel_dan_gamer.Location = new System.Drawing.Point(12, 12);
            this.panel_dan_gamer.Name = "panel_dan_gamer";
            this.panel_dan_gamer.Size = new System.Drawing.Size(346, 98);
            this.panel_dan_gamer.TabIndex = 8;
            // 
            // NewGamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 117);
            this.ControlBox = false;
            this.Controls.Add(this.panel_dan_gamer);
            this.Name = "NewGamer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новая игра";
            this.panel_dan_gamer.ResumeLayout(false);
            this.panel_dan_gamer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_name_gamer;
        private System.Windows.Forms.Button button_dalee;
        private System.Windows.Forms.Panel panel_dan_gamer;
    }
}