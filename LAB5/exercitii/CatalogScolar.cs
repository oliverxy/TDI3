using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CatalogScolar
{
    public string Nume { get; private set; } = string.Empty;
    private List<Elev> Elevi = new List<Elev>();

    public CatalogScolar(string nume) 
    { 
        this.Nume = nume;
    }  
    public void AdaugaElev(Elev elev)
    {
        Elevi.Add(elev);
    }
    public void StergeElev(Elev elev)
    {
        Elevi.Remove(elev);
    }
    public Elev Premiantul
    {
        get
        {
            if (Elevi.Count == 0) { return null; }
            var premiant = Elevi[0];
            var mediaMax = premiant.Media;
            for (int i = 1; i < Elevi.Count; i++)
            {
                Elev elev = Elevi[i];
                var mediaCur = elev.Media;
                if (mediaCur > mediaMax)
                {
                    premiant = elev;
                    mediaMax = mediaCur;

                }
            }

            return premiant;
        }
    }
}


