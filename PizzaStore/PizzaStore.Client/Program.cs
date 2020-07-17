﻿using System;
using System.Collections.Generic;
using PizzaStore.Domain.Models;

namespace PizzaStore.Client
{
    class Program
    {
        static void Main()
        {
            Welcome();
        }

        static void Welcome() 
        {
            Console.WriteLine("Welcome To The Leaning Tower of Pizza");

            // var cart = new String[10];

            var cart = new Cart();

            // List<Pizza> cart2 = new List<Pizza>();

            // Menu(cart);
            Menu2(cart);
        }

        // static void Menu(String[] cart)
        // {
        //     var exit = false;
        //     var index = 0;

        //     do {
        //         Console.WriteLine("------ Menu ------");
        //         Console.WriteLine("Select 1 for a Cheese Pizza");
        //         Console.WriteLine("Select 2 for a Pepperoni Pizza");
        //         Console.WriteLine("Select 3 for a Sausage Pizza");
        //         Console.WriteLine("Select 4 for a Supreme Pizza");
        //         Console.WriteLine("Select 5 for a Custom Pizza");
        //         Console.WriteLine("Select 6 to view Cart");
        //         Console.WriteLine("Select 7 to exit\n");

        //         int select;

        //         int.TryParse(Console.ReadLine(), out select);

        //         if (cart.Length > index) 
        //         {
        //             switch (select) 
        //             {
        //                 case 1:
        //                     cart[index] = "Cheese";
        //                     Console.WriteLine($"{cart[index]} Pizza Added To Cart\n");
        //                     index += 1;
        //                     break;
        //                 case 2:
        //                     cart[index] = "Pepperoni";
        //                     Console.WriteLine($"{cart[index]} Pizza Added To Cart\n");
        //                     index += 1;
        //                     break;
        //                 case 3:
        //                     cart[index] = "Sausage";
        //                     Console.WriteLine($"{cart[index]} Pizza Added To Cart\n");
        //                     index += 1;
        //                     break;
        //                 case 4:
        //                     cart[index] = "Supreme";
        //                     Console.WriteLine($"{cart[index]} Pizza Added To Cart\n");
        //                     index += 1;
        //                     break;
        //                 case 5:
        //                     // TODO: Create 'custom pizza' functionality
        //                     break;
        //                 case 6:
        //                     displayCart(cart);
        //                     break;
        //                 case 7:
        //                     Console.WriteLine("Thanks for visiting!\nSee you next time!");
        //                     exit = true;
        //                     break;
        //             }
        //         } else 
        //         {
        //             displayCart(cart);
        //         }
        //     } while (!exit);
        // }

        static void Menu2(Cart cart)
        {
            var exit = false;
            var startup = new Startup();

            do {
                Console.WriteLine("------ Menu ------");
                Console.WriteLine("Select 1 For Cheese Pizza");
                Console.WriteLine("Select 2 For Pepperoni Pizza");
                Console.WriteLine("Select 3 For Sausage Pizza");
                Console.WriteLine("Select 4 For Customized Pizza");
                Console.WriteLine("Select 5 To View Cart");
                Console.WriteLine("Select 6 To Exit\n");

                int select;

                int.TryParse(Console.ReadLine(), out select);

                switch (select) 
                {
                    case 1:
                        cart.AddPizza(startup.CreatePizza("L", "Deep Dish Crust", new List<string>{"Cheese"}));
                        Console.WriteLine($"Cheese Pizza Added To Cart\n");
                        break;
                    case 2:
                        cart.AddPizza(startup.CreatePizza("L", "Pan Crust", new List<String>{"Cheese, Pepperoni"}));
                        Console.WriteLine($"Pepperoni Pizza Added To Cart\n");
                        break;
                    case 3:
                        cart.AddPizza(startup.CreatePizza("L", "Thin Crust", new List<String>{"Cheese, Sausage"}));
                        Console.WriteLine($"Sausage Pizza Added To Cart\n");
                        break;
                    case 4:
                        cart.AddPizza(startup.CreatePizza("L", "Stuffed Crust", new List<String>{"Cheese, Pepperoni, Sausage, Onions, Bell Peppers, Olives"}));
                        Console.WriteLine($"Custom Pizza Added To Cart\n");
                        break;
                    case 5:
                        cart.displayCart();
                        break;
                    case 6:
                        Console.WriteLine("Thanks for visiting!\nSee you next time!");
                        exit = true;
                        break;
                }
            } while (!exit);
        }

        // static void displayCart(string[] cart)
        // {
        //     Console.WriteLine("------ Cart ------");
        //     foreach(var item in cart)
        //     {
        //         Console.WriteLine(item);
        //     }
        // }

        // static void displayCart2(Cart cart)
        // {
        //     Console.WriteLine("------ Cart ------");
        //     foreach(Pizza pizza in cart.List)
        //     {
        //         Console.WriteLine(pizza);
        //     }
        //     Console.WriteLine("------ **** ------\n");
        // }
    }
}
