using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    enum RefrigeradorType
    {
        WineCooler,
        Office,
        Freezer,
        Integral
    }

    internal class Refrigerador: ElectricProduct
    {
        private int amountOfDoors;
        private RefrigeradorType type;
        private PowerSupply powerSupply;
        

        public Refrigerador(string name, int price, Catagory catagory, Company company, Color color, int amountOfDoors, RefrigeradorType type, PowerSupply powerSupply):base(name, price, catagory,company, color)
        {
            this.amountOfDoors = amountOfDoors;
            this.type = type;
            this.powerSupply = powerSupply;
        }
    }
}
