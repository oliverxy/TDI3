using PoS;
using POS.Cards;
using POS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoS
{
     class Program
    {
        static void Main(string[] args) 
        {
            var pos = new Pos();
            var clCard = new ContactlessCard();
            var cfCard = new ClassicCard();
            var phone = new SmartPhone();
            var cashRegister = new Register();
            cashRegister.AddPos(pos);
            var pos2 = cashRegister.PlataCard(100.0);
            pos2.PlatesteContactFull(cfCard);
            pos2.PlatesteContactLess(clCard);

            pos2.PlatesteContactLess(phone);
            pos2.PlatesteContactLess(clCard);
            cashRegister.PlataCard(200.0).PlatesteContactLess(clCard);
            pos2.PlatesteContactLess(new SmartWatch());
            var dumbWatch = new DumbWatch();
            dumbWatch.AddPhone(phone);

            pos.PlatesteContactLess(dumbWatch);
        }

    }
}
