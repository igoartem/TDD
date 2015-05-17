using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_TDD
{
    class Melody
    {
        public string name_melody;
        public string name_file;

        public Melody()
        {
        }

        public Melody(string name_melody, string name_file)
        {
            this.name_file = name_file;
            this.name_melody = name_melody;
        }
    }
}
