using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_TDD
{
    class Gamer
    {
        public string name { get; set; }
        public int number { get; set; }
        public int rating { get; set; }

        public Gamer() { }

        public Gamer(string name, int number)
        {
            this.name = name;
            this.number = number;
            this.rating = 0;
        }

        public void PlusRating(int kol)
        {
            rating +=kol;
        }

       
    }
}
