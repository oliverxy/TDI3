using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dulap
{
    private int Latime { get; set; }
    private int Lungime { get; set; }
    private int Adancime { get; set; }
    
    public Dulap(int lungime, int latime, int adancime )
    {
        Lungime = lungime;
        Latime = latime;
        Adancime = adancime;
    }
    public int GetVolum => Lungime * Latime * Adancime;
    public string GetDescription => $"{Lungime} /{Latime} / {Adancime}";
}
