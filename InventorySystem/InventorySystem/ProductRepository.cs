using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    public class ProductRepository
    {
        List<Product> p;
        public ProductRepository(List<Product> p)
        {
            this.p = p;
        }

        //1.return total no. of product in list
        public int TotalnoProduct()
        {
            return this.p.Count;
        }

        //2.Add new product in the list and return list with new product
        public List<Product> Add(Product np)
        {
            this.p.Add(np);
            return this.p;
        }

        //3.find a product by type and return list
        public List<Product> Find(string type)
        {
            return this.p.FindAll(x => x.P_type.Equals(type, StringComparison.OrdinalIgnoreCase));
        }

        //4.Delete a product by name and return list
        public List<Product> Delete(string name)
        {
            this.p.Remove(p.Find(x => x.P_name.Equals(name, StringComparison.OrdinalIgnoreCase)));
            return this.p;
        }

        //5.Buy a product with it's name, quantity and return price
        public double Buy(string name, int quantity)
        {
            var pr = p.Find(x => x.P_name.Equals(name, StringComparison.OrdinalIgnoreCase));
            return pr.P_price * quantity;
           
        }
    }
}
