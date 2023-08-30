using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int no = 0;
            ProductCRUD crud = new ProductCRUD();
            do
            {
                Console.WriteLine("--------------");
                Console.WriteLine("1.Product List");
                Console.WriteLine("2.Get Product By ID");
                Console.WriteLine("3.Add Product");
                Console.WriteLine("4.Update Product");
                Console.WriteLine("5.Delete Product");
                Console.WriteLine("Select Your Option");
                int Option = Convert.ToInt32(Console.ReadLine());

                switch (Option)
                {
                    /*--------------------------------//display list-------------------------------*/
                    case 1:
                        List<Product> list = crud.GetProduct();
                        Console.WriteLine("id\tName\tPrice\tCompany");
                        foreach (Product product in list)
                        {
                            Console.WriteLine($"{product.id}\t{product.name}" +
                                $"\t{product.price}\t{product.Company}");
                        }
                        break;

                    /*----------------------------search product---------------------------*/
                    case 2:
                        Console.WriteLine("Enter The Product Id : ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Product p = crud.GetProductByid(id);
                        Console.WriteLine("id\tName\tPrice\tCompany");
                        Console.WriteLine($"{p.id}\t{p.name}\t{p.price}\t{p.Company}");
                        break;
                    /*------------------------------------ADD Product------------------------------------*/
                    case 3:
                        Product p1 = new Product();
                        Console.WriteLine("Enter Product Id :");
                        p1.id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enetr Product Name :");
                        p1.name = Console.ReadLine();
                        Console.WriteLine("Enter Price :");
                        p1.price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Company :");
                        p1.Company = Console.ReadLine();
                        crud.ADDProduct(p1);
                        Console.WriteLine("Product Updated");
                        break;

                    case 4:
                        Product p2 = new Product();
                        Console.WriteLine("Enter Product Id :");
                        p2.id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enetr Product Name :");
                        p2.name = Console.ReadLine();
                        Console.WriteLine("Enter Price :");
                        p2.price = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Company :");
                        p2.Company = Console.ReadLine();
                        crud.UpdateProduct(p2);
                        Console.WriteLine("Product Updated ..");

                        break;

                    case 5:
                        Console.WriteLine("Enter the Product id");
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        crud.DeletProduct(id2);
                        Console.WriteLine($"{id2}Product Deleted !!!!!");
                        break;

                }
                Console.WriteLine("Press 1 for continue ");
                no = Convert.ToInt32(Console.ReadLine());
            }
            while (no == 1);
        }
    }
]]}
