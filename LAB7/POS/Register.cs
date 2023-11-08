using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoS
{
    
    class Register
    {
        private Pos pos;
        public void AddPos(Pos pos) => this.pos = pos;
        public void PlataCash(double suma) => Console.WriteLine($"s-a efectuat plata cash in suma de {suma}");
        public Pos PlataCard(double suma)
        {
            pos.IntroduSumaDePlata(suma);
            return pos;
        }

    }
}
