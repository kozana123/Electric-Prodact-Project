using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum VentilationType
    {
        Overhead,
        Central,
        porteble,
        fan,
    }

    internal class Airconditioner: ElectricProduct
    {
        VentilationType type;
        int energyRate;
        int heatingOutput;
        int coolingOutput;
        PowerSupply powerSupply;

        public Airconditioner(VentilationType type, int energyRate, int heatingOutput, int coolingOutput, string name , int price, Catagory catagory, Company company, Color color, int amountOfDoors, PowerSupply powerSupply):base(name, price, catagory, company, color)
        {
            this.type = type;
            this.energyRate = energyRate;
            this.heatingOutput = heatingOutput;
            this.coolingOutput = coolingOutput;
        }
        
        public void SetVentilationType(VentilationType type) {  this.type = type; }

        public void SetEnergyRate(int energyRate) {  this.energyRate = energyRate; }

        public void SetHeatingOutput(int heatingOutput) {  this.heatingOutput = heatingOutput; }

        public void SetCoolingOutput(int coolingOutput) {  this.coolingOutput = coolingOutput;}

        public void SetPowerSupply(PowerSupply powerSupply) { this.powerSupply = powerSupply; }

        public VentilationType
        public PowerSupply GetPowerSupply() { return this.powerSupply; }

    }
}
