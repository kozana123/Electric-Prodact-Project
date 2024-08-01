using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    enum VentilationType
    {
        Overhead,
        Central,
        Porteble,
        Fan,
    }
    
    internal class Airconditioner: ElectricProduct
    {
        static int amount = 0;
        VentilationType type;
        int energyRate;
        int heatingOutput;
        int coolingOutput;
        PowerSupply powerSupply;

        public Airconditioner(VentilationType type, int energyRate, int heatingOutput, int coolingOutput, string name , int price, Company company, Color color, PowerSupply powerSupply, Catagory catagory = Catagory.Ventilation) :base(name, price, catagory, company, color)
        {
            this.type = type;
            this.energyRate = energyRate;
            this.heatingOutput = heatingOutput;
            this.coolingOutput = coolingOutput;
            amount++;
        }

        public Airconditioner()
        {

        }

        public void SetVentilationType(VentilationType type) {  this.type = type; }

        public void SetEnergyRate(int energyRate) {  this.energyRate = energyRate; }

        public void SetHeatingOutput(int heatingOutput) {  this.heatingOutput = heatingOutput; }

        public void SetCoolingOutput(int coolingOutput) {  this.coolingOutput = coolingOutput;}

        public void SetPowerSupply(PowerSupply powerSupply) { this.powerSupply = powerSupply; }

        public VentilationType GetVentilationType() { return this.type; }

        public int GetEnergyRate() {  return this.energyRate; }

        public int GetHeatingOutput() {  return this.heatingOutput; }
        public int GetCoolingOutput() {  return this.coolingOutput; }
        public PowerSupply GetPowerSupply() { return this.powerSupply; }

        public static int GetAmount()
        {
            return amount;
        }

        public static void RemoveAmount()
        {
            amount--;
        }

        public override string ToString()
        {
            
            return $"{base.ToString()}VentilationType: {type}\nEnergyRate: {energyRate}\nHeating Output: {heatingOutput}\nCooling Output: {coolingOutput}";
        }

    }
}
