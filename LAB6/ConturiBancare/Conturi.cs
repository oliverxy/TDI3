using Conturi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conturi
{
    abstract class Cont
    {
        private string nume;
        private readonly double plafonDescoperireSold;
        protected double sold;
        public static int NrConturi { get; private set; }
        private Guid id;

        public Cont(string nume, double plafonDescoperireSold)
        {
            this.id = Guid.NewGuid();
            this.nume = nume;
            this.plafonDescoperireSold = plafonDescoperireSold;
            NrConturi++;
        }

        public virtual bool DepunereNumerar(double sumaDepusa)
        {
            if (sumaDepusa < 0)
            {
                Console.WriteLine("Suma invalida");
                return false;
            }
            sold += sumaDepusa;
            return true;
        }

        public virtual bool RetragereNumerar(double sumaRetrasa)
        {
            if (sumaRetrasa <= 0)
            {
                Console.WriteLine("Suma invalida");
                return false;
            }
            if (sold + sumaRetrasa < 0)
            {
                Console.WriteLine("Fonduri insuficiente");
                return false;
            }
            sold -= sumaRetrasa;
            return true;
        }

 
        public override string ToString()
        {
            return $"{nume}-{id} : {sold}$";
        }
    }
    class ContInvestitii : ContEconomii
    {
        private int ziuaExtragerii;
        public ContInvestitii(string nume, double rataDobanzii, int ziuaExtragerii) : base(nume, rataDobanzii)
        {
            if (ziuaExtragerii < 0)
            {
                ziuaExtragerii = 1;
            }   
            if (ziuaExtragerii > 31)
            {
                ziuaExtragerii = 31;
            }
            this.ziuaExtragerii = ziuaExtragerii;
        }
        public override bool RetragereNumerar(double sumaRetrasa)
        {
            if ((DateTime.UtcNow.Day >= ziuaExtragerii) || (ziuaExtragerii == DateTime.DaysInMonth(DateTime.UtcNow.Year, DateTime.UtcNow.Month)))
            {
                return base.RetragereNumerar(sumaRetrasa);
            }
            else
            {
                Console.WriteLine("Ziua retragerii incorecta");
                return false;
            }
        }
    }
}
