using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.IO;

namespace Lab_TDD
{
    public partial class Main : Form
    {
        MediaPlayer player = new MediaPlayer();
        System.TimeSpan p;
        int mel;
       
        int prav;

        List<int> list_use_melody = new List<int>();
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            static_class.list_melody = new List<Melody>();
            string []lines;
            string line1, line2;
            int count,kol_vo_melody,ind=0;
                try
                {
                    string s = @"melody\melody.txt";
                    lines = System.IO.File.ReadAllLines(s);
                    count = lines.Count();
                    if(count == 0)
                    {
                        MessageBox.Show("Файл пуст!");
                        this.Close();
                    }
                    kol_vo_melody = Convert.ToInt32(lines[ind++]);
                    static_class.put = lines[ind++];

                    for (int i = 0; i < kol_vo_melody; i++)
                    {
                        line1 = lines[ind++];
                        line2 = lines[ind++];
                        static_class.list_melody.Add(new Melody(line1,line2));
                    }
                          
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    this.Close();
                }
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
            new_game();
            gen_melody();

        }

        public void new_game()
        {
            panel1.Enabled = true;
            label_gamer.Text = static_class.gamer.name;
            label7.Text =Convert.ToString( static_class.gamer.rating);

        }

        public void gen_melody()
        {
            Random rand = new Random();

            
            bool flag=true;
            while(flag)
            {
                if (list_use_melody.Count == static_class.list_melody.Count-1)
                {
                    theend();
                    flag = false;
                    return;
                }
                mel = rand.Next(static_class.list_melody.Count); //номер мелодии
                int yy = list_use_melody.Find(x => x == mel);
                if (yy != mel)
                {
                    flag = false;
                    list_use_melody.Add(mel);
                }
            }

            prav = rand.Next(3); // правильный ответ

            List<int> list = new List<int>();

            int ost; 

            while (list.Count!=4)
            {
                if (list.Count == prav)
                    list.Add(mel);
                ost = rand.Next(static_class.list_melody.Count);
                int y = list.Find(x => x == ost);
                if(y!=ost && ost !=mel)
                    list.Add(ost);
            }

            button6.Text = static_class.list_melody[list[0]].name_melody;
            button7.Text = static_class.list_melody[list[1]].name_melody;
            button8.Text = static_class.list_melody[list[2]].name_melody;
            button9.Text = static_class.list_melody[list[3]].name_melody;
            button_play.Enabled = true;

        }

        public void theend()
        {
            string ss = Convert.ToString(static_class.gamer.rating);
            string message = "Конец игры. Вы набрали "+ ss +" очков";
            string caption = "Конец игры!";
            MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Question);
            panel1.Enabled = false;
            list_use_melody.Clear();
           

        }

        public void otvet(int otv)
        {
            if (otv == prav)
            {
                static_class.gamer.PlusRating(static_class.pp);
                label7.Text = Convert.ToString(static_class.gamer.rating);

            }
         
            gen_melody();
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_play_Click(object sender, System.EventArgs e)
        {
            static_class.list_melody[mel].Play_Melody();
            button_play.Enabled = false;

        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            static_class.list_melody[mel].Stop_Melody();
            otvet(0);
        }

        private void button7_Click(object sender, System.EventArgs e)
        {
            static_class.list_melody[mel].Stop_Melody();
            otvet(1);
        }

        private void button8_Click(object sender, System.EventArgs e)
        {
            static_class.list_melody[mel].Stop_Melody();
            otvet(2);
        }

        private void button9_Click(object sender, System.EventArgs e)
        {
            static_class.list_melody[mel].Stop_Melody();
            otvet(3);
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            static_class.list_melody[mel].Stop_Melody();
            gen_melody();
        }

        private void выходToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
           
            string message = "Вы действительно хотите выйти из игры?";
            string caption = "Выход";
            var result=MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes) //Если нажал Да
                this.Close();
        }

        private void справкаToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            
            string message = "Угадай мелодию v0.1";
            string caption = "Справка";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Question);
        }
    }
}
