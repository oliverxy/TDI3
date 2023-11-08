using POS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Cards
{
    class SmartWatch : IContactlessPay
    {
        private Guid cardData = Guid.NewGuid();
        public void Apropie() => Console.WriteLine("Apropie ceasul");
        public string GetCardData() => cardData.ToString();
    }
}
