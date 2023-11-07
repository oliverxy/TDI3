using POS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Cards
{
    class ContactlessCard : ClassicCard, IContactlessPay
    {
        public void Apropie()
        {
            Console.WriteLine("Cardul a fost apropiat.");
        }
    }
}
