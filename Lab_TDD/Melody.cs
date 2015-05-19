using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Lab_TDD
{
    class Melody
    {
        public string name_melody;
        public string name_file;
        MediaPlayer player = new MediaPlayer();
        System.TimeSpan p;

        public Melody()
        {
        }

        public Melody(string name_file, string name_melody)
        {
            this.name_file = name_file;
            this.name_melody = name_melody;
        }

        public void Play_Melody()
        {
            string s = static_class.put+ this.name_file;
            player.Open(new Uri(s, UriKind.Absolute));
            player.Play();
        }

        public void Stop_Melody()
        {
            player.Stop();
            player.Close();
        }

    }
}
