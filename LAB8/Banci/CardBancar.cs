using System;
namespace Banci
{


    public class CardBancar
    {
        private Guid id;
        public CardBancar() => this.id = Guid.NewGuid();
        public void IntroduCard() => Console.WriteLine("Introduceti card ...");
        public void ScoateCard() => Console.WriteLine("Scoateti card ...");
        public Guid GetCardData => id;
    }
}