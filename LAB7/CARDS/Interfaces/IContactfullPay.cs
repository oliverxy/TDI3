﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Interfaces
{
    public interface IContactfullPay
    {
        public void IntroduCard();
        public Guid GetCardData();
        public void ExtrageCard();

    } 
}
