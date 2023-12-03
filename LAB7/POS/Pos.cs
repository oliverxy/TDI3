using POS.Interfaces;
using Banci;
namespace PoS
{
    class Pos:IPos
    {
        private double sumaDePlata;
        private   Connect()
        {
            try
            {
                //Banci.Banca.Connect();
            }
            catch
            {
                try
                {
                    //Banci.Banca.Connect();
                }
                catch 
                {
                    throw new BankConnectException("Eroare conectare la banca !");
                }
            }
        }
        private void Disconnect()
        {
            //Banci.Banca.Disconnect();
        }

        public                                         void IntroduSumaDePlata(double suma) 
        { 
            this.sumaDePlata = suma;
            Console.WriteLine($"Am incarcat suma de plata {suma}");
        }
        public void PlatesteContactLess(IContactlessPay device)
        {
            device.Apropie();
            var cardData = device.GetCardData();
            Console.WriteLine($"plata in valoare de {sumaDePlata} efectuata cu succes cu cardul {cardData}");
            sumaDePlata = 0;
        }
        public void PlatesteContactFull(IContactfullPay device)
        {
            device.IntroduCard();
            var cardData = device.GetCardData();
            Console.WriteLine($"plata in valoare de {sumaDePlata} efectuata cu succes cu cardul {cardData}");
            device.ExtrageCard();
            sumaDePlata = 0;
        }
    }
}