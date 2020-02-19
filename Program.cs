using System;
using System.Collections;
using System.Collections.Generic;

namespace Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Hi! This little program will help you to manage expenses on food throughout the week, and then \n" +
                "you can see how much will it cost a month \n" +
                "type add and press enter to input the name, " +
                "price and how many times you plan to buy the item in week\n" +
                "type remove and the enter which item to remove (list will be displayed)\n" +
                "when you've adding items, just type calculate and the program will show the list of items\n" +
                "and the sum for the month \n" +
                "after calculating type save if you want to save the list in a separate file (feature coming soon)\n" +
                "type exit to finish the program"
            );
            
            int finish = 0; 
            List<Food> foodList = new List<Food>();
            
            while (true)
            {
                Console.WriteLine("Choose command (add, calculate, exit)");
                string operation = Console.ReadLine();
                if (operation.ToLower() == "add")
                {
                    Add(foodList);
                }
                /*
                else if (operation.ToLower() == "remove")
                {
                    Remove();
                }
                */
                else if (operation.ToLower() == "calculate")
                {
                    Calculate(foodList);
                }
                /*
                if (operation.ToLower() == "save")
                {
                    Save();
                }
                */
                else if (operation.ToLower() == "exit")
                {
                    Console.WriteLine("Bye bye");
                    break;
                }
            }
        }
        
        static void Add(List<Food> itemsList)
        {
            Food item = new Food();
            
            Console.WriteLine("Write name of item");
            string nameItem = Console.ReadLine();
            Console.WriteLine("Write price of item");
            int priceItem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many times you get item per week?");
            int quantityItem = Convert.ToInt32(Console.ReadLine());
            
            item.name = nameItem;
            item.price = priceItem;
            item.quantityPerWeek = quantityItem;
            
            itemsList.Add(item);
        }
        /*
        static void Remove()
        {
            
        }
        */

        static void Calculate(List<Food> itemsList)
        {
            int result = 0;
            for (int i = 0; i < itemsList.Count; i++)
            {
                result += itemsList[i].price;
            }
            Console.WriteLine(result);
        }
        /*
        static void Save()
        {
            
        }
        */
        
    }
}