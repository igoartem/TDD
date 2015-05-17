using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_TDD
{
    public partial class NewGamer : Form
    {
        int num = 1;
        public NewGamer()
        {
            InitializeComponent();
        }

        private void button_dalee_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text == "")
            {
                MessageBox.Show("Введите имя игрока!");
                return;
            }
            else
            {
                static_class.list_gamer.Add(new Gamer(textBox_name.Text,num-1));

                if (num == static_class.kol_gamer)
                    this.Close();

                num++;
                label_num_gamer.Text = Convert.ToString(num);
                textBox_name.Text = "";
            }
        }

        private void button_kol_gamer_Click(object sender, EventArgs e)
        {
            static_class.kol_gamer = (int)numericUpDown_gamers.Value;
            panel_dan_gamer.Enabled = true;
            panel_kol_gamer.Enabled = false;
            static_class.list_gamer = new List<Gamer>();
            label_num_gamer.Text = Convert.ToString(num);

        }
    }
}
