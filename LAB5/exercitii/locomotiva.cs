using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercitii
{
    public class Locomotiva
    {
        public string Name { get; private set; } = string.Empty;
        public int PowerKw { get; private set; }
        public bool isStarted { get; private set; } = false;

        public Locomotiva(string name, int putere)
        {
            this.Name = name;
            this.PowerKw = putere;
        }
        public void Start() { this.isStarted = true; }
        public void Stop()  { this.isStarted = false; }
        

    }
}
