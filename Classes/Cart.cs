using System;
using System.Collections.Generic;

namespace Interface.Classes
{
    public class Cart : ICart
    {

        List<Product> cart = new List<Product>();


        public void Alter(int code, Product newProduct)
        {

            cart.Find(x => x.Code == code).Name = newProduct.Name;
            cart.Find(x => x.Code == code).Price = newProduct.Price;
            cart.Find(x => x.Code == code).Code = newProduct.Code;


        }

        public void Delete(int code)
        {

            Product productDelete = cart.Find(x => x.Code == code);


            if (productDelete != null)
            {
                Console.WriteLine();
                cart.Remove(productDelete);
            }
        }                                         

        public void List()
        {

            foreach (Product item in cart)
            {
                
                Console.WriteLine();
                Console.WriteLine("Product: " + item.Name);
                Console.WriteLine();
                Console.WriteLine("Code: " + item.Code);
                Console.WriteLine();
                Console.WriteLine("Price: $" + item.Price);
                Console.WriteLine();
            
            }
        
        }

        
        public void Register(Product product)
        {
            Console.WriteLine();
            cart.Add(product);
        }


    }
}