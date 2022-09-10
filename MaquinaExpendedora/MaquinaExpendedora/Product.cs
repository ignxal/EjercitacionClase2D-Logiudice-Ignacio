using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaExpendedora
{
    public class Product
    {
        private string name;
        private double price;
        private int code;
        private static int lastCode;
        private int amount;

        static Product(){
            lastCode = 1000;
        }

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
            this.code = lastCode;
            lastCode++;
        }

        public Product(string name, double price, int amount): this(name, price)
        {
            this.amount = amount;
        }

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Amount { get => amount; set => amount = value; }
        public double Code { get => code;}
    }
    

}
