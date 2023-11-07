namespace Banci
{
    public class Banca 
    {
        Dictionary<Guid, CardBancar> carduriBanca = new Dictionary<Guid, CardBancar>();
        Dictionary<Guid, string> conturiBanca = new Dictionary<Guid, string>();

        public static int NrConturi { get; private set; }
        public static int NrConexiuni { get; private set; }

        //  List<CardBancar> carduri = new List<CardBancar>();

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
            conturiBanca.Add(cont.id, cont.nume);
            return cont.id;
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
            var card = new CardBancar();
            carduriBanca.Add(card.GetCardData, card);
        }

        public void Plateste (Guid contId, double suma)
        {
            if (!conturiBanca.ContainsKey(contId))
            {
                throw new CardException("Contul nu exista.");
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