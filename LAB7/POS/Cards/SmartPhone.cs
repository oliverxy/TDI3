using POS.Interfaces;
using System;

namespace POS.Cards
{
    class SmartPhone : IContactlessPay
    {
        private Guid phoneId = Guid.NewGuid();

        public void Apropie()
        {
            Console.WriteLine("Apropie telefonul");
        }

        public string GetCardData()
        {
            return $"phone id : {phoneId}";
        }

    }
}
