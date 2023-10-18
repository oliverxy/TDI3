using exercitii;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace exercitii
{
    class Vagon
    {
        public string Seria { get; set; }
        public int Masa { get; set; }
        public int anFabricatie { get; set; }
/*        public Vagon(string seria, int masa, int anFabricatie)
        {
            Seria = seria;
            Masa = masa;
            this.anFabricatie = anFabricatie;
        }
 */   }

    class VagonMarfa : Vagon
    {
        private int capacitate;
        private readonly TipMarfa tipMarfa = TipMarfa.cereale;
        public VagonMarfa(int capacitate, TipMarfa marfa)
        {
            this.capacitate = capacitate;
            this.tipMarfa = marfa;
        }
    }
    class VagonPersoane : Vagon
    {
        private int nrLocuri;
        public bool IsDoorOpened { get; private set; } = false;
        public bool IsDoorClosed { get; private set; } = true;
        public VagonPersoane(int nrLocuri)
        {
            this.nrLocuri = nrLocuri;
        }
        public void OpenDoors()
        {
            IsDoorOpened = true;
            IsDoorClosed = false;
        }
        public void CloseDoors()
        {
            IsDoorClosed = true;
            IsDoorOpened = false;
        }
    }
    

    class VagonPersoaneClasaI : VagonPersoane
    {
        public bool IsACOpened { get; private set; } = false;
        public bool IsACClosed { get; private set; } = true;
        public VagonPersoaneClasaI(int nrLocuri):base(nrLocuri)
        {

        }
        public void OpenAC()
        {
            IsACOpened = true;
            IsACClosed = false;
        }
        public void CloseAC()
        {
            IsACClosed = true;
            IsACClosed = false;
        }

    }
}