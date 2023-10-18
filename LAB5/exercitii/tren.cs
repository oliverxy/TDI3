namespace exercitii
{
    class Tren
    {
        public string Nume { get; set; }
        private List<VagonPersoane> Vagoane = new List<VagonPersoane>();
        private List<Locomotiva> Locomotive = new List<Locomotiva>();
        public Tren(string nume)
        {
            this.Nume = nume;
        }
        public void AdaugaLocomotiva(Locomotiva locomotiva)
        {
            Locomotive.Add(locomotiva);
        }
        public void StergeLocomotiva(Locomotiva locomotiva)
        {
            Locomotive.Remove(locomotiva);
        }
        public void AdaugaVagon(VagonPersoane vagon)
        {
            Vagoane.Add(vagon);
        }
        public void StergeVagon(VagonPersoane vagon)
        {
            Vagoane.Remove(vagon);
        }
        public void Porneste()
        {
            foreach (var vagon in Vagoane)
            {
                vagon.CloseDoors();
                if (vagon is VagonPersoaneClasaI)
                {
                    (vagon as VagonPersoaneClasaI).OpenAC();
                }
            }
            foreach (var locomotiva in Locomotive)
            {
                locomotiva.Start();
            }
        }
        public void Opreste()
        {
            foreach (var locomotiva in Locomotive)
            {
                locomotiva.Stop();
            }
            foreach (var vagon in Vagoane)
            {
                if (vagon is VagonPersoaneClasaI)
                {
                    (vagon as VagonPersoaneClasaI).CloseAC();
                }
                vagon.OpenDoors();
            }
        }
    }
}