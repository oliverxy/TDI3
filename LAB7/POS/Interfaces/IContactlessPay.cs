 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Interfaces
{
    public interface IContactlessPay
    {
        public void Apropie();
        public string GetCardData();
    }
}
