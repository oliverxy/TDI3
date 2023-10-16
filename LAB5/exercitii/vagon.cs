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
        private string Seria { get; set; }
        private int Masa { get; set; }
        private int anFabricatie { get; set; }
        public Vagon(string seria, int masa, int anFabricatie)
        {
            Seria = seria;
            Masa = masa;
            this.anFabricatie = anFabricatie;
        }
    }

    class VagonMarfa : Vagon
    {
        private int capacitate;
        private readonly TipMarfa tipMarfa;
        public VagonMarfa(int capacitate, TipMarfa marfa) : base(seria, masa, anFabricatie)
        {
            this.capacitate = capacitate;
            this.tipMarfa = marfa;
        }

    }
}