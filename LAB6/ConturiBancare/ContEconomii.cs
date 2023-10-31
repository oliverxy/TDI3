namespace Conturi
{
    class ContEconomii : Cont
    {
        private double rataDobanzii;
        private const double PlafonDescoperireSold = 0.0;

        public ContEconomii(string nume, double rataDobanzii) : base(nume,PlafonDescoperireSold)
        {
            this.rataDobanzii = rataDobanzii;
        }

        public override bool DepunereNumerar(double sumaDepusa)
        {
            if (base.DepunereNumerar(sumaDepusa))
            {
                sold *= 1+rataDobanzii;
                return true;
            }
            return false;
        }
    }
}
