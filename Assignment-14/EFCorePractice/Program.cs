using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EFCorePractice
{
    //_____________________________________________________________________________________________
    public class Product                                //models
    {
        [Key]
        public int Id{get;set;}
        public string Name{get;set;}
    }
    //________________________________________________________________________________________________
    public class ProductContext:DbContext               //database connectivity
    {
        //DML Operations
        /* public ProductContext(DbContextOptions dbContextOptions):base(dbContextOptions) 
        {
            
        } */
        private const string cs="Host=localhost;Port=5432;User ID=postgres;Password=1234;Database=PracticeDB;Pooling=true;"; // Database name  is PracticeDB 
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseNpgsql(cs);
        }
        
        //local operations
        public DbSet<Product> products{get;set;}// table name will be products
    }
    //________________________________________________________________________________________________

    public class ProductOperations                     //productrepository
    {
        ProductContext productContext=new ProductContext();
        public void fetchPoduct(int a)                      //function for fetching data
        {
            /* var temp=productContext.products.Find(101);
                if (temp != null)
                {
                    Console.WriteLine(temp.Name);
                } */

            
            /* var product = (from s in productContext.products
                        where s.Name == "Gurpreet Singh"
                        select s).FirstOrDefault<Product>();
                        Console.WriteLine(product.Id); */

        var productss = productContext.products
                  .Where(s => s.Id== a)
                  .FirstOrDefault<Product>();
        if(productss==null)
        {
            Console.WriteLine("Product not found !!!!");
        }        
        else{         
        Console.WriteLine(productss.Name);
        }
        }
        public void insertProduct(Product product)
        {
            var productss = productContext.products
                  .Where(s => s.Id== product.Id)
                  .FirstOrDefault<Product>();
            if(productss!=null)
            {
                Console.WriteLine("product already exist !!!!");
                
            }
            else
            {
            productContext.Add(product);
            productContext.SaveChanges();
            Console.WriteLine("Insert successfully");
            }
        }
        public void updateProduct(int ID,string n)
        {
            var productss = productContext.products
                  .Where(s => s.Id == ID)
                  .FirstOrDefault<Product>();
            if(productss==null)
            {
                Console.WriteLine("Selected Product not found !!!!");
            }
            else
            {
            productss.Name=n;
            productContext.SaveChanges();
            Console.WriteLine("Update successfully !!!!");
            }
            
        }
        public void deleteProduct(int id)
        {
             var productss = productContext.products
                  .Where(s => s.Id == id)
                  .FirstOrDefault<Product>();
            if(productss==null)
            {
                Console.WriteLine("Selected Product not found !!!!");
            }
            else
            {
            Product product=new Product();
            productContext.Remove(productss);
            productContext.SaveChanges();
            Console.WriteLine("data deleted successfully");
            }
        }

        /* public ProductOperations()
                {
                    
                } */
            
    }
        

   //_________________________________________________________________________________________________- 
    class Program
    {
        public static void Main()
        {
            
            ProductOperations productOperations=new ProductOperations();
            string looper="Y";
            while(looper!="X")
            {
                Console.WriteLine("\t\t\t______MENU_______\nPress 1: to fetch the products\nPress 2: to insert the products\nPress 3: to update the products\nPress 4: to delete the products\n\n Enter Your Choice :-");
                int ch=Convert.ToInt32(Console.ReadLine());
                
                switch(ch)
                {
                    case 1:
                        Console.WriteLine("enter the product id:-");
                        int id=Convert.ToInt32(Console.ReadLine());
                        productOperations.fetchPoduct(id);
                        break;
                    case 2:
                        Product product= new Product();
                        Console.WriteLine("\t\t____Entry for New Product____ ");
                        Console.WriteLine("Enter Product Id :");
                        product.Id=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Product Name :");
                        product.Name=Console.ReadLine();
                        productOperations.insertProduct(product);
                        break;
                    case 3:
                        Console.WriteLine("\t\t____Update product Details____");
                        Console.WriteLine("Enter the Product Id :- ");
                        int id1=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Product Name :-");
                        string name=Console.ReadLine();
                        productOperations.updateProduct(id1,name);
                        break;
                    case 4:
                        Console.WriteLine("\t\t____Delete Product____");
                        Console.WriteLine("Enter the Product Id :- ");
                        int id2=Convert.ToInt32(Console.ReadLine());
                        productOperations.deleteProduct(id2);
                        break;
                    default:
                        Console.WriteLine("invalid input");
                        break;
                    
                }
                Console.WriteLine("Press X for exit or Press Enter to Continue");
                looper=Convert.ToString(Console.ReadLine());
            }
            
        }
    }
}

