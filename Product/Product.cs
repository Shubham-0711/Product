using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class Product
    {
        public int id {  get; set; }
        public string name { get; set; }
        public int price { get ; set; }
        public string Company { get; set; }

    }

    public class ProductCRUD
    {
        private List<Product> productlist;
        public ProductCRUD()
        {
            productlist = new List<Product>()
            {
                new Product() {id=1,name="laptop",price=50000,Company="HP"},
                new Product() {id = 2, name = "PC", price = 60000, Company = "ASUS"},
                new Product() {id = 3,name="Moniter",price=30000,Company="LG"}
            };
        }

        /*--------------------------------//display list-------------------------------*/
        public List<Product> GetProduct()
        {
            return productlist;
        }

        /*-----------------------Grt product by id---------------------------------------*/
        public Product GetProductByid(int id)
        {
            Product product = new Product();
            foreach (Product p in productlist)
            {
                if (p.id == id)
                {
                    product = p; 
                    break;
                }
            }
            return product;
        }
        /*------------------------------------ADD Product ------------------------------*/
        public void ADDProduct(Product P)
        {
            productlist.Add(P);

        }

        /*-------------------------------------Update Product------------------------------------------------*/
        public void UpdateProduct(Product P)
        {
            foreach (Product item in productlist)
            {
                if(item.id == P.id)
                {
                    item.name = P.name;
                    item.price = P.price;
                    item.Company = P.Company;
                    break;
                }
            }
        }
        /*------------------------------Delete Product---------------------------*/
        public void DeletProduct(int id)
        {
            foreach(Product item in productlist)
            {
                if (item.id == id)
                {
                    productlist.Remove(item);
                    break;
                }
            }
        }
    }
}
