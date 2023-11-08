using POS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Cards
{
    public class DumbWatch : IContactlessPay
    {
        private SmartPhone phone;
        public void AddPhone(SmartPhone phone) { this.phone = phone; }
        public void Apropie() => Console.WriteLine("Apropiem ceasul dumb");
        public Guid GetCardData() => phone == null ? Guid.Empty : phone.GetCardData();
    }
}
