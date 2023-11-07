namespace Conturi
{
    abstract class Cont
    {
        private string nume;
        private readonly double plafonDescoperireSold;
        protected double sold;
        private Guid id;

        public Cont(string nume, double plafonDescoperireSold)
        {
            this.id = Guid.NewGuid();
            this.nume = nume;
            this.plafonDescoperireSold = plafonDescoperireSold;
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
            return $"{nume}-{id} : {sold}$";
        }
    }
}
