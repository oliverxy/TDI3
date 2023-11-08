using Conturi.Interfaces;

namespace Conturi
{
    public class Cont : ICont
    {
        private string nume;
        private readonly double plafonDescoperireSold;
        protected double sold;
        private readonly Guid id;

        public Guid GetId()
        {
            return id;
        }
        public string GetNume()
        {
            return nume;
        }

        public Cont(string nume, double plafonDescoperireSold)
        {
            this.id = Guid.NewGuid();
            this.nume = nume;
            this.plafonDescoperireSold = plafonDescoperireSold;
        }

        public virtual void DepunereNumerar(double sumaDepusa)
        {
            if (sumaDepusa < 0)
            {
                throw new InsufficientFundsException("Suma invalida !");
                //Console.WriteLine("Suma invalida");
                //return false;
            }
            sold += sumaDepusa;
            //return true;
        }

        public virtual void RetragereNumerar(double sumaRetrasa)
        {
            if (sumaRetrasa <= 0)
            {
                // Console.WriteLine("Suma invalida");
                throw new InsufficientFundsException("Suma eronata !");
            }
            if (sold + sumaRetrasa < 0)
            {
                // Console.WriteLine("Fonduri insuficiente");
                throw new InsufficientFundsException("Fonduri insuficiente !");
            }
            sold -= sumaRetrasa;
        }


        public override string ToString()
        {
            return $"{nume}-{GetId()} : {sold}$";
        }

    }
}
