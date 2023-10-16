using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercitii
{
    public class Locomotiva
    {
        public string Name { get; set; }
        private int Power { get; set; }
        public bool isStarted { get; private set; } = false;

        public Locomotiva(string name, int putere)
        {
            this.Name = name;
            this.Power = putere;
        }
        public void Start() { this.isStarted = true; }
        public void Stop()  { this.isStarted = false; }
        

    }
}
