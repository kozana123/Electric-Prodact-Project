using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Catagory
    {
        Kitchen,
        Display,
        Ventilation,

    }

    enum Company
    {
        LG,
        Sumsung,
        Electra,
        Haier,
        Xiaomi,
    }

    enum Color
    {
        Black,
        White,
        Green,
        Blue,
        Gray,
    }

    internal class ElectricProduct
    {
        private string name;
        private int price;
        private Catagory catagory;
        private Company company;
        private Color color;
        

        public ElectricProduct(string name, int price, Catagory catagory, Company company, Color color)
        {
            this.name = name;
            this.price = price;
            this.catagory = catagory;
            this.company = company;
            this.color = color;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetPrice(int price)
        {
            this.price = price;
        }

        public void SetCatagory(Catagory catagory)
        {
            this.catagory = catagory;
        }

        public void SetComnpany(Company company)
        {
            this.company = company;
        }

        public void SetColor(Color color)
        {
            this.color = color;
        }

        public string GetName() { return name; }
        public int GetPrice() { return price; }
        public Catagory GetCatagory() {  return catagory; }
        public Company GetCompany() { return company;}
        public Color GetColor() { return color;}



    }

    

    
}
