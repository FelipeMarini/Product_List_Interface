using System;
using Interface.Classes;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cart cart = new Cart();

            
            Product p1 = new Product();

            p1.Code = 1234;
            p1.Name ="Playstation 5";
            p1.Price = 5000;
            
            
            
            Product p2 = new Product();

            p2.Code = 1235;
            p2.Name ="X Box Series S";
            p2.Price = 4000;
            
            
            
            Product p3 = new Product();

            p3.Code = 1236;
            p3.Name ="Nintendo Switch";
            p3.Price = 3000;


            cart.Register(p1);
            cart.Register(p2);
            cart.Register(p3);

            cart.List();

            Console.ForegroundColor = ConsoleColor.Blue;

            cart.Alter(p2.Code,p3);

            cart.List();

            Console.ForegroundColor = ConsoleColor.Green;

            cart.Delete(p1.Code);

            cart.List();

        }
    }
}
