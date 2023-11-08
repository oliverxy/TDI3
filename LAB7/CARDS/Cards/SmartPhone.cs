using POS.Interfaces;
using System;

namespace POS.Cards
{
    public class SmartPhone : IContactlessPay
    {
        private Guid id = Guid.NewGuid();
        public void Apropie() => Console.WriteLine("Apropie telefonul");
        public Guid GetCardData() => id;

    }
}
