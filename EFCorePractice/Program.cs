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
        Console.WriteLine(productss.Name);
        }
        public void insertProduct(Product product)
        {
            productContext.Add(product);
            productContext.SaveChanges();
            Console.WriteLine("Insert successfully");
        }
        public void updateProduct(int ID,string n)
        {
            var productss = productContext.products
                  .Where(s => s.Id == ID)
                  .FirstOrDefault<Product>();
            productss.Name=n;
            productContext.SaveChanges();
            Console.WriteLine("Update successfully !!!!");
        }
        public void deleteProduct(int id)
        {
             var productss = productContext.products
                  .Where(s => s.Id == id)
                  .FirstOrDefault<Product>();
            Product product=new Product();
            productContext.Remove(productss);
            productContext.SaveChanges();
            Console.WriteLine("data deleted successfully");

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
            productOperations.fetchPoduct(101);
            productOperations.updateProduct(102,"Gurpreet Singh");
            Product product= new Product();
            product.Id=104;
            product.Name="Karan Dhayani";
            productOperations.insertProduct(product);
            productOperations.deleteProduct(103);

            
        }
    }
}
