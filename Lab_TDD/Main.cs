using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Media;

namespace Lab_TDD
{
    public partial class Main : Form
    {
        MediaPlayer player = new MediaPlayer();
        System.TimeSpan p;
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            player.Open(new Uri("C:\\sound.mp3", UriKind.Absolute));
            player.Play();
            
           
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            
            player.Pause();
            p = player.Position;
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            
            player.Stop();
            

        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            player.Position = p;
            player.Play();
        }

        private void файлToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }

        private void начатьИгруToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            NewGamer newgame = new NewGamer();
            newgame.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
