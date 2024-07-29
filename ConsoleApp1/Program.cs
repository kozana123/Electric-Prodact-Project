using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricProdactProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            StoreManager storeManager = new StoreManager();

            PowerSupply powerSupply1 = new PowerSupply(true, 120);
            PowerSupply powerSupply2 = new PowerSupply(false, 170);
            PowerSupply powerSupply3 = new PowerSupply(true, 75);
            PowerSupply powerSupply4 = new PowerSupply(false, 32);
            PowerSupply powerSupply5 = new PowerSupply(true, 100);
            PowerSupply powerSupply7 = new PowerSupply(true, 920);

            ScreenType screenType1 = new ScreenType(Technology.LED, 60, 4);
            ScreenType screenType2 = new ScreenType(Technology.QLED, 120, 4);
            ScreenType screenType3 = new ScreenType(Technology.OLED, 60, 2);

            Screen screen1 = new Screen(55, screenType1,powerSupply1, "EL500HK", 1290,Company.Electra, Color.Black);
            Screen screen2 = new Screen(65, screenType2, powerSupply2, "QE65Q60D", 4390, Company.Sumsung, Color.Gray);
            Screen screen3 = new Screen(43, screenType3, powerSupply3, "43L5AG", 1199, Company.Xiaomi, Color.Black);


            Refrigerador refrigerador1 = new Refrigerador("EL685GS", 5290, Company.Electra, Color.Black, 4, RefrigeradorType.Integral, powerSupply4);
            Refrigerador refrigerador2 = new Refrigerador("SJ-9731", 12309, Company.LG, Color.White, 5, RefrigeradorType.Integral, powerSupply2);
            Refrigerador refrigerador3 = new Refrigerador("HWS49GA ", 2990, Company.Haier, Color.Gray, 1, RefrigeradorType.WineCooler, powerSupply5);
                    
            Airconditioner airconditioner1 = new Airconditioner(VentilationType.Overhead, 4, 9365, 11020, "Coolair inverter Wifi", 1190, Company.Electra, Color.White, powerSupply7);
            Airconditioner airconditioner2 = new Airconditioner(VentilationType.Overhead, 5, 9212, 10577, "KORI-INV-12X WIFI Inverter", 2000, Company.Haier, Color.Black, powerSupply7);
            Airconditioner airconditioner3 = new Airconditioner(VentilationType.Porteble, 3,1200, 1200, "Camping", 3290, Company.Electra, Color.Blue, powerSupply2);

            Screen[] screensArr = new Screen[] { screen1, screen2, screen3 };
            Refrigerador[] refrigeradorsArr = new Refrigerador[] { refrigerador1, refrigerador2, refrigerador3 };
            Airconditioner[] airconditionersArr = new Airconditioner[] {airconditioner1, airconditioner2, airconditioner3};

            storeManager.ToString();

            airconditionersArr = storeManager.AddAirconditioner(airconditionersArr);

            foreach (Airconditioner airconditioner in airconditionersArr)
            {
                Console.WriteLine(airconditioner.GetName());
            }


//            do
//            {
//                switch (choice)
//                {
//                    case 1:
//                        Console.WriteLine(@"
//what do you wnat to add?
//1) Add refrigeretor
//2) add screen
//3) add aircondishiner");

//                        choice = int.Parse(Console.ReadLine());

//                        switch (choice)
//                        {
//                            case 1:
//                                storeManager.AddProduct();

//                        }

//                }
//            }
        }
    }
}
