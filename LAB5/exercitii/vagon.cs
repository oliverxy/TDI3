using exercitii;
using Microsoft.VisualBasic;
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
        public string Seria { get; private set; }
        public int Masa { get; private set; }
        public int anFabricatie { get; private set; }
        public static int nrTotalVagoane { get; private set; }
        public Vagon(string seria, int masa, int anFabricatie)
        {
            this.Seria = seria;
            this.Masa = masa;
            this.anFabricatie = anFabricatie;
            nrTotalVagoane ++;
        }
        public virtual void PleacaDinGara()
        {

        }
        public virtual void SosesteInGara()
        {

        }
        public override string ToString()
        {
            return $"{Masa} {anFabricatie}";
        }

    }

    class VagonMarfa : Vagon
    {
        private int capacitate;
        private readonly TipMarfa tipMarfa = TipMarfa.cereale;
        public VagonMarfa(string seria, int masa, int anFabricatie,int capacitate, TipMarfa marfa) :base(seria, masa, anFabricatie)
        {
            this.capacitate = capacitate;
            this.tipMarfa = marfa;
        }
        public override string ToString()
        {
            return "vagon marfa";
        }

    }
    class VagonPersoane : Vagon
    {
        private int nrLocuri;
        public bool IsDoorOpened { get; private set; } = false;
        public bool IsDoorClosed { get; private set; } = true;
        public VagonPersoane(string seria, int masa, int anFabricatie, int nrLocuri):base(seria, masa, anFabricatie)
        {
            this.nrLocuri = nrLocuri;
        }
        private void OpenDoors()
        {
            IsDoorOpened = true;
            IsDoorClosed = false;
        }
        private void CloseDoors()
        {
            IsDoorClosed = true;
            IsDoorOpened = false;
        }
        public override void PleacaDinGara()
        {
            base.PleacaDinGara();
            CloseDoors();
        }
        public override void SosesteInGara()
        {
            base.SosesteInGara();
            OpenDoors();
        }
        public override string ToString()
        {
            return $"vagon persoana {base.ToString()}";
        }

    }


    class VagonPersoaneClasaI : VagonPersoane
     {
        public bool IsACOpened { get; private set; } = false;
        public bool IsACClosed { get; private set; } = true;
        public VagonPersoaneClasaI(string seria, int masa, int anFabricatie, int nrLocuri):base(seria, masa, anFabricatie,nrLocuri)
        {

        }
        private void OpenAC()
        {
            IsACOpened = true;
            IsACClosed = false;
        }
        private void CloseAC()
        {
            IsACClosed = true;
            IsACClosed = false;
        }
        public override void PleacaDinGara()
        {
            base.PleacaDinGara();
            OpenAC();
        }
        public virtual void SosesteInGara()
        {
            base.SosesteInGara();
            CloseAC();
        }
        public override string ToString()
        {
            return $"vagon clasa I {base.ToString()}";
        }


    }
    class VagonCuseta : VagonPersoaneClasaI
    {
        public bool IsLightOn { get; private set; } = false;
        public bool IsLightOff { get; private set; } = true;
        public VagonCuseta(string seria, int masa, int anFabricatie, int nrLocuri) :base(seria, masa, anFabricatie, nrLocuri)
        {
            
        }
        private void PornesteLumini()
        {
            IsLightOn = true;
            IsLightOff = false;
        }
        private void StingeLumini()
        {
            IsLightOn = false;
            IsLightOff = true;
        }
        public override void PleacaDinGara()
        {
            base.PleacaDinGara();
            PornesteLumini();
        }
        public virtual void SosesteInGara()
        {
            base.SosesteInGara();
            StingeLumini();
        }
        public override string ToString()
        {
            return $"vagon cuseta {base.ToString()}";
        }
    }
}
