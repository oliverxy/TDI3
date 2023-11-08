namespace Banci
{
    public class Banca 
    {
        Dictionary<Guid, Guid> carduriBanca = new Dictionary<Guid, Guid>();
        Dictionary<Guid, string> conturiBanca = new Dictionary<Guid, string>();

        public static int NrConturi { get; private set; }
        public static int NrConexiuni { get; private set; }

        public Banca()
        {
            NrConturi++;
        }

        public Guid CreeazaCont(string nume, double plafon)
        {
            if (conturiBanca.Count > 2)
            {
                throw new CardException("Prea multe conturi deschise.");
            }
            var cont = new Conturi.Cont(nume, plafon);
            conturiBanca.Add(cont.GetId(), cont.GetNume());
            return cont.GetId();
        }

        public void EmiteCard(Guid contId)
        {
            if (!conturiBanca.ContainsKey(contId))
            {
                throw new CardException("Contul nu exista.");
            }
            if (carduriBanca.Count> 2)
            {
                throw new CardException("Prea multe carduri.");

            }
            var card = new POS.Cards.ContactlessCard();
            carduriBanca.Add(card.GetCardData(),contId);
        }

        public void Plateste (Guid idCard, double suma)
        {
            if (!carduriBanca.ContainsKey(idCard))
            {
                throw new CardException("Cardul nu exista.");
            }
            if (carduriBanca[idCard]==Guid.Empty)
            {
                throw new CardException("Cardul nu are cont asociat.");
            }
            // ???RetragerNumerar(suma)
        }

        public void Connect()
        {
            if (NrConexiuni > 3)
            {
                throw new ConnectionsException("Prea multe conexiuni");
            }
            NrConexiuni++;
            Console.WriteLine("Connected");
        }

        public void Disconnect()
        {
            if (NrConexiuni > 0) 
            {
                NrConexiuni--;
            }
            Console.WriteLine("Disconnected");
        }
    }
}