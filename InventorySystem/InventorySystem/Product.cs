using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    public class Product
    {
        private string Name,Type;
        private double Price;
        private int Quantity;
        public Product(string Name, double Price, int Quantity, string Type)
        {
            this.P_name = Name;
            this.P_price = Price;
            this.P_type = Type;
            this.P_quantity = Quantity;
        }
        public string P_name
        {
            get { return Name; }
            set {Name = value; }
        }

        public double P_price
        {
            get { return Price; }
            set {Price = value; }
        }

        public int P_quantity
        {
            get { return Quantity; }
            set {Quantity = value; }
        }

        public string P_type
        {
            get { return Type; }
            set {Type = value; }
        }

    }
}
