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
        static int amount = 0;
        private int amountOfDoors;
        private RefrigeradorType type;
        private PowerSupply powerSupply;
        

        public Refrigerador(string name, int price, Company company, Color color, int amountOfDoors, RefrigeradorType type, PowerSupply powerSupply, Catagory catagory = Catagory.Kitchen) :base(name, price, catagory,company, color)
        {
            this.amountOfDoors = amountOfDoors;
            this.type = type;
            this.powerSupply = powerSupply;
        }

        public void SetAmountOfDoors(int amountOfDoors) { this.amountOfDoors=amountOfDoors; }

        public void SetRefrigeradorType(RefrigeradorType type) {  this.type = type; }

        public void SetPowerSupply(PowerSupply powerSupply) { this.powerSupply = powerSupply; }
        public int GetAmountOfDoors() { return this.amountOfDoors; }

        public RefrigeradorType GetRefrigeradorType() {  return this.type; }
        public PowerSupply GetPowerSupply() {  return this.powerSupply; }

        public static int GetAmount()
        {
            return amount;
        }


    }
}
