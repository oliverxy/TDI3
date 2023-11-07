﻿using POS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Cards
{
    public class ClassicCard : IContactfullPay
    {
        private Guid cardData = Guid.NewGuid();
        
        public void ExtrageCard()
        {
            Console.WriteLine("Extrage cardul");
        }

        public string GetCardData()
        {
            return cardData.ToString();
        }

        public void IntroduCard()
        {
            Console.WriteLine("Extrage cardul");

        }
    }

}