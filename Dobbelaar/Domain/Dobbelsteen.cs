using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dobbelaar.Domain
{
    class Dobbelsteen
    {
        readonly Random _random = new Random();

        public Dobbelsteen()
        {
            Gooi();
        }

        private int Waarde { get; set; }

        public int Gooi()
        {
            Waarde = _random.Next(1, 7);
            return Waarde;
        }
    }
}
