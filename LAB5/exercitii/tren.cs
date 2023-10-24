using System.Text;

namespace exercitii
{
    class Tren
    {
        public string Nume { get; private set; }
        private List<Vagon> vagoane = new List<Vagon>();
        private List<Locomotiva> locomotive = new List<Locomotiva>();
        public Tren(string nume, Locomotiva locomotiva)
        {
            this.Nume = nume;
            this.locomotive.Add(locomotiva);
        }
        public void AdaugaLocomotiva(Locomotiva locomotiva)
        {
            locomotive.Add(locomotiva);
        }
        public void StergeLocomotiva(Locomotiva locomotiva)
        {
            locomotive.Remove(locomotiva);
        }
        public void AdaugaVagon(VagonPersoane vagon)
        {
            vagoane.Add(vagon);
        }
        public void StergeVagon(VagonPersoane vagon)
        {
            vagoane.Remove(vagon);
        }
        public void PleacaDinGara()
        {
            foreach (var vagon in vagoane)
            {
                if (vagon is VagonPersoane)
                {
                   // (vagon as VagonPersoane).CloseDoors();
                   // if (vagon is VagonPersoaneClasaI)
                   // {
                   //     (vagon as VagonPersoaneClasaI).OpenAC();
                   // }
                   vagon.PleacaDinGara();
                }
            }
            foreach (var locomotiva in locomotive)
            {
                locomotiva.Start();
            }
        }
        public void SosesteInGara()
        {
            foreach (var locomotiva in locomotive)
            {
                locomotiva.Stop();
            }
            foreach (var vagon in vagoane)
            {
                //if (vagon is VagonPersoaneClasaI)
                //{
                //    (vagon as VagonPersoaneClasaI).CloseAC();
                //}
                //(vagon as VagonPersoane).OpenDoors();
                vagon.SosesteInGara();
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Nume);
            foreach (var vagon in vagoane)
            {
                sb.AppendLine(vagon.ToString());
            }
            return sb.ToString();
        }
    }
}