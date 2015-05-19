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
                Gamer nn= new Gamer(textBox_name.Text);
                static_class.gamer=nn;
                    this.Close();

            }
        }

       
    }
}
