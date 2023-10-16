using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CatalogScolar
{
    private string nume { get; set; } = string.Empty;
    private List<Elev> Elevi = new List<Elev>();

    public void AdaugaElev(Elev elev)
    {
        Elevi.Add(elev);
    }
    public void StergeElev(Elev elev)
    {
        Elevi.Remove(elev);
    }
    public Elev GetPremiantul()
    {
        Elev result = Elevi[0];
        foreach (var elev in Elevi)
        {
            if (elev.GetMedia() > result.GetMedia())
            {
                result = elev;
            }
        }
        return result;
    }
}


