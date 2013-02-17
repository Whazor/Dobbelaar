using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dobbelaar.Domain
{
    class Dobbelsteen
    {
        readonly Random random = new Random();

        public Dobbelsteen()
        {
            Gooi();
        }

        private int _waarde;

        public int Waarde
        {
            get { return _waarde; }
        }

        public void Gooi()
        {
            _waarde = random.Next(1, 7);
        }
    }
}
