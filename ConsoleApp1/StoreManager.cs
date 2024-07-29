using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StoreManager
    {

        public Airconditioner[] AddAirconditioner(Airconditioner[] airconditioners)
        {
            int choise = 0;
            Airconditioner[] temp = new Airconditioner[airconditioners.Length + 1];
            for (int i = 0; i < airconditioners.Length; i++)
            {
                temp[i] = airconditioners[i];
            }

            Console.WriteLine(@"
What Ventilation type:
1) Overhead
2) Central
3) Porteble
4) Fan");

            choise = int.Parse(Console.ReadLine());
            VentilationType ventilation = VentilationType.Central;

            switch (choise)
            {
                case 1:
                    ventilation = VentilationType.Overhead;
                break;

                case 2:
                    ventilation = VentilationType.Central;
                break;

                case 3:
                    ventilation = VentilationType.Porteble;
                break;

                case 4:
                    ventilation = VentilationType.Fan;
                break;
            }

            int energyRate;

            do
            {
                Console.WriteLine("Enter energy rate (1-5):");
                energyRate = int.Parse(Console.ReadLine());
            }
            while (energyRate > 5 || energyRate < 1);

            int heatingOutput;
            int coolingOutput;

            Console.WriteLine("Enter heating output rate:");
            heatingOutput = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter cooling output rate:");
            coolingOutput = int.Parse(Console.ReadLine());

            Console.WriteLine("Name of the prodact:");
            string name = Console.ReadLine();

            Console.WriteLine("Price:");
            int price = int.Parse(Console.ReadLine());

            Console.WriteLine(@"
What Company:
1) LG
2) Electra
3) Haier
4) Sumsung
5) Xiaomi");

            choise = int.Parse(Console.ReadLine());
            Company company = Company.LG;

            switch (choise)
            {
                case 1:
                    company = Company.LG;
                    break;

                case 2:
                    company = Company.Electra;
                    break;

                case 3:
                    company = Company.Haier;
                    break;

                case 4:
                    company = Company.Sumsung;
                    break;

                case 5:
                    company = Company.Xiaomi;
                    break;
            }

            Console.WriteLine(@"
What Company:
1) Blue
2) Black
3) White
4) Green
5) Gray");

            choise = int.Parse(Console.ReadLine());
            Color color = Color.Blue;

            switch (choise)
            {
                case 1:
                    color = Color.Blue;
                    break;

                case 2:
                    color = Color.Black;
                    break;

                case 3:
                    color = Color.White;
                    break;

                case 4:
                    color = Color.Green;
                    break;

                case 5:
                    color = Color.Gray;
                    break;
            }

            Console.WriteLine(@"
Is the power supply has Eco Mode?
1) Yes
2) No");
            bool eco = false;
            choise = int.Parse (Console.ReadLine());

            if (choise == 1)
                eco = true;
            else
                eco = false;
            Console.WriteLine("How much Watt:");
            int watt = int.Parse (Console.ReadLine());
            PowerSupply powerSupply = new PowerSupply(eco, watt);

            Airconditioner airconditioner = new Airconditioner(ventilation, energyRate, heatingOutput, coolingOutput, name, price, company, color, powerSupply);

            temp[temp.Length -1] = airconditioner;
            return temp;


        }
        public void AddRefrigerador()
        {

            Airconditioner[] temp;

        }
        public void AddScreen()
        {

            Airconditioner[] temp;

        }


        //public void ToString()
        //{

        //}

    }


}
