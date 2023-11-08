namespace Conturi
{
    public class ContCurent : Cont
    {
        private const double PlafonDescoperireSold = 5000.0;

        public ContCurent(string nume):base(nume,PlafonDescoperireSold) 
        { 
        }
      
    }
}
