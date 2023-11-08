using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conturi.Interfaces
{
    public interface ICont
    {
        Guid GetId();
        string GetNume();
        void DepunereNumerar(double sumaDepusa);
        void RetragereNumerar(double sumaRetrasa);

    }
}
