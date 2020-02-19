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
                Console.WriteLine("Choose command (add, remove, display, calculate, exit)");
                string operation = Console.ReadLine();
                if (operation.ToLower() == "add")
                {
                    Add(foodList);
                }
                
                else if (operation.ToLower() == "remove")
                {
                    Remove(foodList);
                }
                
                else if (operation.ToLower() == "display")
                {
                    DisplayList(foodList);
                }
                
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
                
                else if (operation == String.Empty)
                {
                    Console.WriteLine("You didn't enter anything. Please enter command");
                }

                else
                {
                    Console.WriteLine("Incorrect command");
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
        
        static void Remove(List<Food> itemsList)
        {
            for (int i = 0; i < itemsList.Count; i++)
            {
                Console.WriteLine($"{itemsList[i].name} | index: {i}");
            }
            
            Console.WriteLine("Enter index of item to remove");
            int index = Convert.ToInt32(Console.ReadLine());

            itemsList.RemoveAt(index);
        }
        

        static void Calculate(List<Food> itemsList)
        {
            int result = 0;
            for (int i = 0; i < itemsList.Count; i++)
            {
                Console.WriteLine($"{itemsList[i].name} | {itemsList[i].price}NOK | purchase in a week: {itemsList[i].quantityPerWeek}");
                result += (itemsList[i].price * itemsList[i].quantityPerWeek) * 4;
            }
            Console.WriteLine($"TOTAL: {result} NOK | {result/10} EURO");
        }

        static void DisplayList(List<Food> itemsList)
        {
            foreach (var item in itemsList)
            {
                Console.WriteLine($"{item.name} | {item.price} NOK | {item.price/10} EURO");
            }
        }
        /*
        static void Save()
        {
            
        }
        */
        
    }
}