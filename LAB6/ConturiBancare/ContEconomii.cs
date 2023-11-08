namespace Conturi
{
    public class ContEconomii : Cont
    {
        private double rataDobanzii;
        private const double PlafonDescoperireSold = 0.0;

        public ContEconomii(string nume, double rataDobanzii) : base(nume,PlafonDescoperireSold)
        {
            this.rataDobanzii = rataDobanzii;
        }

        public override void RetragereNumerar(double sumaDepusa)
        {
            try
            {
                base.RetragereNumerar(sumaDepusa);
                sold *= 1+rataDobanzii;
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }
    }
}
