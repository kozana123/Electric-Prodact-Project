using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Screen: ElectricProduct
    {
        static int amount = 0;
        private double size;
        private ScreenType screenType;
        private PowerSupply powerSupply;
        public Screen(double size, ScreenType type, PowerSupply powerSupply ,string name, int price, Company company, Color color, Catagory catagory = Catagory.Display) : base(name, price, catagory, company, color)
        {
            this.size = size;
            this.screenType = type;
            this.powerSupply = powerSupply;
            
        }

        public void SetSize(double size) {  this.size = size; }

        public void SetScreenType(ScreenType screenType) { this.screenType = screenType; }

        public void SetPowerSupply(PowerSupply powerSupply) {  this.powerSupply = powerSupply; }

        public double GetSize() { return this.size;}

        public ScreenType GetScreenType() {  return this.screenType;}

        public PowerSupply GetPowerSupply() {  return this.powerSupply;}

        public static int GetAmount()
        {
            return amount;
        }


    }
}
