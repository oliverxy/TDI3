using POS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Cards
{
    public class SmartWatch : IContactlessPay
    {
        private Guid id = Guid.NewGuid();
        public void Apropie() => Console.WriteLine("Apropie ceasul");
        public Guid GetCardData() => id;
    }
}
