using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PowerSupply
    {
        bool ecoMode;
        int watt;

        public PowerSupply(bool ecoMode, int watt)
        {
            this.ecoMode = ecoMode;
            this.watt = watt;
        }

        public void SetEcoMode(bool ecoMode)
        {
            this.ecoMode = ecoMode;
        }

        public void SetWatt(int watt)
        {
            this.watt = watt;
        } 

        public int GetWatt() { return this.watt; }
        public bool GetEcoMode() {  return this.ecoMode; }

        public override string ToString()
        {
            return $"eco: {ecoMode}, Watt:{watt}";
        }

    }   
}
