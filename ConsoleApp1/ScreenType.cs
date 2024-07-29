using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Technology
    {
        LED,
        OLED,
        QLED,
        QNED,
    }

    internal class ScreenType
    {
        int speed;
        int resolution;
        Technology technology;


        public ScreenType(Technology technology, int speed, int resolution)
        {
            this.technology = technology;
            this.speed = speed;
            this.resolution = resolution;
        }

        public void SetSpeed(int speed) { this .speed = speed; }
        public void SetResolution(int resolution) {  this .resolution = resolution; }

        public void SetTechnology(Technology technology) {  this .technology = technology; }

        public int GetSpeed() { return this .speed;}

        public int GetResolution() { return this .resolution;}

        public Technology GetTechnology() {  return this .technology;}



    }
}
