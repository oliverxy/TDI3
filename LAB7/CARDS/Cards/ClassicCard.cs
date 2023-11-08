using POS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Cards
{
    public class ClassicCard : IContactfullPay
    {
        private Guid id = Guid.NewGuid();
        public void ExtrageCard() => Console.WriteLine("Extrage cardul");
        public Guid GetCardData() => id;
        public void IntroduCard() => Console.WriteLine("Extrage cardul");
    }

}
