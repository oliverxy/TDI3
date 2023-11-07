namespace Conturi
{
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
        public override void RetragereNumerar(double sumaRetrasa)
        {
            if ((DateTime.UtcNow.Day >= ziuaExtragerii) || (ziuaExtragerii == DateTime.DaysInMonth(DateTime.UtcNow.Year, DateTime.UtcNow.Month)))
            {
                try
                {
                    base.RetragereNumerar(sumaRetrasa);
                }
                catch (InsufficientFundsException ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }
            else
            {
                Console.WriteLine("Ziua retragerii incorecta");
            }
        }
    }
}
