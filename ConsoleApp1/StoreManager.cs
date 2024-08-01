using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StoreManager
    {
        int cupa = 0;

        public void ShowCupa() {Console.WriteLine($"Amout of money in the cash register: {cupa}");}
        public Airconditioner[] AddAirconditioner(Airconditioner[] airconditioners, PowerSupply[] powerSupplies)
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
            PowerSupply powerSupply = powerSupplies[0];
            Console.WriteLine(@"
Do you want to choose from exsisting power supply?
1)yes
2)no");
            choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    Console.WriteLine("Choose one of the power supply:");
                    for (int i = 0; i < powerSupplies.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}) {powerSupplies[i].ToString()}");
                    }
                    choise = int.Parse(Console.ReadLine());
                    powerSupply = powerSupplies[choise - 1];
                    break;

                case 2:
                    Console.WriteLine(@"
Is the power supply has Eco Mode?
1) Yes
2) No");
                    bool eco = false;
                    choise = int.Parse(Console.ReadLine());

                    if (choise == 1)
                        eco = true;
                    else
                        eco = false;
                    Console.WriteLine("How much Watt:");
                    int watt = int.Parse(Console.ReadLine());
                    powerSupply = new PowerSupply(eco, watt);
                    break;
            }

            Airconditioner airconditioner = new Airconditioner(ventilation, energyRate, heatingOutput, coolingOutput, name, price, company, color, powerSupply);

            temp[temp.Length - 1] = airconditioner;
            return temp;


        }

        public Refrigerador[] AddRefregirator(Refrigerador[] refrigiredors, PowerSupply[] powerSupplies)
        {
            int choise = 0;
            Refrigerador[] temp = new Refrigerador[refrigiredors.Length + 1];
            for (int i = 0; i < refrigiredors.Length; i++)
            {
                temp[i] = refrigiredors[i];
            }

            Console.WriteLine(@"
What Refrigerador type:
1) WineColler
2) Office
3) Freezer
4) Integral");

            choise = int.Parse(Console.ReadLine());
            RefrigeradorType RefrigeradorType = RefrigeradorType.WineCooler;

            switch (choise)
            {
                case 1:
                    RefrigeradorType = RefrigeradorType.WineCooler;
                    break;

                case 2:
                    RefrigeradorType = RefrigeradorType.Office;
                    break;

                case 3:
                    RefrigeradorType = RefrigeradorType.Freezer;
                    break;

                case 4:
                    RefrigeradorType = RefrigeradorType.Integral;
                    break;
            }

            int amountOfDoors;

            do
            {
                Console.WriteLine("Enter how many doors does the refrigedor has?: ");
                amountOfDoors = int.Parse(Console.ReadLine());
            }
            while (amountOfDoors > 5 || amountOfDoors < 1);


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

            PowerSupply powerSupply = powerSupplies[0];
            Console.WriteLine(@"
Do you want to choose from exsisting power supply?
1)yes
2)no");
            choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    Console.WriteLine("Choose one of the power supply:");
                    for (int i = 0; i < powerSupplies.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}) {powerSupplies[i].ToString()}");
                    }
                    choise = int.Parse(Console.ReadLine());
                    powerSupply = powerSupplies[choise - 1];
                    break;

                case 2:
                    Console.WriteLine(@"
Is the power supply has Eco Mode?
1) Yes
2) No");
                    bool eco = false;
                    choise = int.Parse(Console.ReadLine());

                    if (choise == 1)
                        eco = true;
                    else
                        eco = false;
                    Console.WriteLine("How much Watt:");
                    int watt = int.Parse(Console.ReadLine());
                    powerSupply = new PowerSupply(eco, watt);
                    break;
            }

            Refrigerador refrigerador = new Refrigerador(name, price, company, color, amountOfDoors, RefrigeradorType, powerSupply);

            temp[temp.Length - 1] = refrigerador;
            return temp;


        }

        public Screen[] AddScreen(Screen[] screens, PowerSupply[] powerSupplies, ScreenType[] screenTypes)
        {
            int choise = 0;
            Screen[] temp = new Screen[screens.Length + 1];
            for (int i = 0; i < screens.Length; i++)
            {
                temp[i] = screens[i];
            }

            double size;

            do
            {
                Console.WriteLine("Enter the size of the screen: ");
                size = int.Parse(Console.ReadLine());
            }
            while (size > 80 || size < 10);


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

            PowerSupply powerSupply = powerSupplies[0];
            Console.WriteLine(@"
Do you want to choose from exsisting power supply?
1)yes
2)no");
            choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    Console.WriteLine("Choose one of the power supply:");
                    for (int i = 0; i < powerSupplies.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}) {powerSupplies[i].ToString()}");
                    }
                    choise = int.Parse(Console.ReadLine());
                    powerSupply = powerSupplies[choise - 1];
                    break;

                case 2:
                    Console.WriteLine(@"
Is the power supply has Eco Mode?
1) Yes
2) No");
                    bool eco = false;
                    choise = int.Parse(Console.ReadLine());

                    if (choise == 1)
                        eco = true;
                    else
                        eco = false;
                    Console.WriteLine("How much Watt:");
                    int watt = int.Parse(Console.ReadLine());
                    powerSupply = new PowerSupply(eco, watt);
                    break;
            }

            ScreenType screenType = screenTypes[0];

            Console.WriteLine(@"
Do you want to choose from exsisting screens?
1)yes
2)no");
            choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    Console.WriteLine("Choose one of the screens type:");
                    for (int i = 0; i < screenTypes.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}) {screenTypes[i]}");
                    }
                    choise = int.Parse(Console.ReadLine());
                    screenType = screenTypes[0];

                    break;

                case 2:
                    Console.WriteLine(@"
What Screen type:
1) LED
2) OLED
3) QLED
4) QNED");

                    choise = int.Parse(Console.ReadLine());
                    Technology screenTec = Technology.LED;

                    switch (choise)
                    {
                        case 1:
                            screenTec = Technology.LED;
                            break;

                        case 2:
                            screenTec = Technology.OLED;
                            break;

                        case 3:
                            screenTec = Technology.QLED;
                            break;

                        case 4:
                            screenTec = Technology.QNED;
                            break;
                    }

                    Console.WriteLine("Enter the max speed that you want: ");
                    int speed = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the resolution: ");
                    int resolution = int.Parse(Console.ReadLine());



                    screenType = new ScreenType(screenTec, speed, resolution);
                    break;
            }

            Screen screen = new Screen(size, screenType, powerSupply, name, price, company, color);

            temp[temp.Length - 1] = screen;
            return temp;

        }

        public Airconditioner[] RemoveAirconditioner(Airconditioner[] airconditioners)
        {

            int choise = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Choose prodact to remove:");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < airconditioners.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {airconditioners[i].ToString()}");
                Console.WriteLine();
            }
            choise = int.Parse(Console.ReadLine());

            Airconditioner[] temp = new Airconditioner[airconditioners.Length - 1];
            int position = 0;
            for (int i = 0; i < airconditioners.Length; i++)
            {
                if (i != choise - 1)
                {
                    temp[position] = airconditioners[i];
                    position++;
                }
                else
                    continue;
            }

            Airconditioner.RemoveAmount();
            cupa += airconditioners[choise - 1].GetPrice();
            return temp;
        }

        public Refrigerador[] RemoveRefregirator(Refrigerador[] refrigiredors)
        {
            int choise = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Choose prodact to remove:");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < refrigiredors.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {refrigiredors[i].ToString()}");
                Console.WriteLine();
            }
            choise = int.Parse(Console.ReadLine());

            Refrigerador[] temp = new Refrigerador[refrigiredors.Length - 1];
            int position = 0;
            for (int i = 0; i < refrigiredors.Length; i++)
            {
                if (i != choise - 1)
                {
                    temp[position] = refrigiredors[i];
                    position++;
                }
                else
                    continue;
            }

            Refrigerador.RemoveAmount();
            cupa += refrigiredors[choise - 1].GetPrice();
            return temp;
        }

        public Screen[] RemoveScreen(Screen[] screens)
        {
            int choise = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Choose prodact to remove:");
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < screens.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {screens[i].ToString()}");
                Console.WriteLine();
            }
            choise = int.Parse(Console.ReadLine());

            Screen[] temp = new Screen[screens.Length - 1];
            int position = 0;
            for (int i = 0; i < screens.Length; i++)
            {
                if (i != choise - 1)
                {
                    temp[position] = screens[i];
                    position++;
                }
                else
                    continue;
            }

            Screen.RemoveAmount();
            cupa += screens[choise - 1].GetPrice();
            return temp;
        }

        public void MostExpensive(Screen[] screens, Airconditioner[] airconditioners, Refrigerador[] refrigeradors)
        {

            int max = screens[0].GetPrice();

            for(int i = 0; i < screens.Length; i++)
            {
                if(max < screens[i].GetPrice())
                {
                    max = screens[i].GetPrice();
                }
            }

            for (int i = 0; i < airconditioners.Length; i++)
            {
                if (max < airconditioners[i].GetPrice())
                {
                    max = airconditioners[i].GetPrice();
                }
            }

            for (int i = 0; i < refrigeradors.Length; i++)
            {
                if (max < refrigeradors[i].GetPrice())
                {
                    max = refrigeradors[i].GetPrice();
                }
            }

            foreach (Screen screen in screens)
            {
                if (screen.GetPrice() == max)
                    Console.WriteLine(screen.ToString());
            }

            foreach (Airconditioner airconditioner in airconditioners)
            {
                if (airconditioner.GetPrice() == max)
                    Console.WriteLine(airconditioner.ToString());
            }

            foreach (Refrigerador refrigerador in refrigeradors)
            {
                if (refrigerador.GetPrice() == max)
                    Console.WriteLine(refrigerador.ToString());
            }
        }

        public void LessExpensive(Screen[] screens, Airconditioner[] airconditioners, Refrigerador[] refrigeradors)
        {

            int min = screens[0].GetPrice();
            Object lessExpensive = screens[0];

            for (int i = 0; i < screens.Length; i++)
            {
                if (min > screens[i].GetPrice())
                {
                    min = screens[i].GetPrice();
                    lessExpensive = screens[i];
                }
            }

            for (int i = 0; i < airconditioners.Length; i++)
            {
                if (min > airconditioners[i].GetPrice())
                {
                    min = airconditioners[i].GetPrice();
                    lessExpensive = airconditioners[i];
                }
            }

            for (int i = 0; i < refrigeradors.Length; i++)
            {
                if (min > refrigeradors[i].GetPrice())
                {
                    min = refrigeradors[i].GetPrice();
                    lessExpensive = refrigeradors[i];
                }
            }

            foreach (Screen screen in screens)
            {
                if(screen.GetPrice() == min)
                    Console.WriteLine(screen.ToString());
            }

            foreach (Airconditioner airconditioner in airconditioners)
            {
                if (airconditioner.GetPrice() == min)
                    Console.WriteLine(airconditioner.ToString());
            }

            foreach (Refrigerador refrigerador in refrigeradors)
            {
                if (refrigerador.GetPrice() == min)
                    Console.WriteLine(refrigerador.ToString());
            }
        }

        public void ScreenPrice(Screen[] screens)
        {
            int choise = 0;

            for (int i = 0;i < screens.Length;i++)
            {
                Console.WriteLine($"{i+1}\nName: {screens[i].GetName()}\nPrice: {screens[i].GetPrice()}$");
            }

            choise = int.Parse( Console.ReadLine() );

            Console.WriteLine("Enter the new price:");
            screens[choise - 1].SetPrice(int.Parse(Console.ReadLine()));
        }

        public void RefrigeradorPrice(Refrigerador[] refregerador)
        {
            int choise = 0;

            for (int i = 0; i < refregerador.Length; i++)
            {
                Console.WriteLine($"{i + 1}\nName: {refregerador[i].GetName()}\nPrice:{refregerador[i].GetPrice()}$");
            }

            choise = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the new price:");
            refregerador[choise - 1].SetPrice(int.Parse(Console.ReadLine()));
        }

        public void AirconditionerPrice(Airconditioner[] airconditioner)
        {
            int choise = 0;

            for (int i = 0; i < airconditioner.Length; i++)
            {
                Console.WriteLine($"{i + 1}\nName: {airconditioner[i].GetName()}\nPrice:{airconditioner[i].GetPrice()}$");
            }

            choise = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the new price:");
            airconditioner[choise - 1].SetPrice(int.Parse(Console.ReadLine()));
        }

        public void itionerPrice(ElectricProduct[] airconditioner)
        {
            int choise = 0;

            for (int i = 0; i < airconditioner.Length; i++)
            {
                Console.WriteLine($"{i + 1}\nName: {airconditioner[i].GetName()}\nPrice:{airconditioner[i].GetPrice()}$");
            }

            choise = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the new price:");
            airconditioner[choise - 1].SetPrice(int.Parse(Console.ReadLine()));
        }

    }


}