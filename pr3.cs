using System;
using System.Collections.Generic;

namespace ExpenseTrackingModule
{
    // [This class represents a single expense item]
    public class Expense
    {
        public string Category { get; set; } // [Stores the category name]
        public int Amount { get; set; }      // [Stores the cost as a whole number]

        // [Constructor to create the expense]
        public Expense(string category, int amount)
        {
            Category = category;
            Amount = amount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // [List to store multiple expenses]
            List<Expense> expenseList = new List<Expense>();
            bool keepAdding = true; // [Flag to control our loop]

            Console.WriteLine("===== Expense Tracking Module =====");

            // [Loop to allow entering multiple expenses]
            while (keepAdding)
            {
                Console.WriteLine();
                Console.Write("Enter Expense Category: ");
                string category = Console.ReadLine();

                Console.Write("Enter Expense Amount: ");
                string amountInput = Console.ReadLine();

                // [Try-Catch block to handle invalid user inputs]
                try
                {
                    // [Check if input is text instead of a number]
                    if (!int.TryParse(amountInput, out int amount))
                    {
                        throw new FormatException();
                    }

                    // [Check if the amount is negative or zero]
                    if (amount <= 0)
                    {
                        throw new ArgumentException();
                    }

                    // [If input is valid, add it to our list]
                    expenseList.Add(new Expense(category, amount));

                    Console.WriteLine("Expense Added Successfully.");
                }
                catch (FormatException)
                {
                    // [Handle completely invalid input (like text)]
                    Console.WriteLine("Invalid Input! Please enter a numeric value.");
                }
                catch (ArgumentException)
                {
                    // [Handle valid numbers that are negative or zero]
                    Console.WriteLine("Invalid Input! Amount must be greater than zero.");
                }

                // [Ask the user if they want to add another item]
                Console.WriteLine();
                Console.Write("Do you want to add another expense? (y/n): ");
                string choice = Console.ReadLine();

                // [If they type anything other than 'y', stop the loop]
                if (choice?.ToLower() != "y")
                {
                    keepAdding = false;
                }
            }

            // [End of data entry - Print the final results]
            Console.WriteLine("\nThank You for Using Expense Tracker.\n");

            // [Print all individual expense details]
            Console.WriteLine("------ Expense Details ------");
            int totalExpenses = 0; // [Variable to calculate the total sum]

            if (expenseList.Count == 0)
            {
                Console.WriteLine("No valid expenses were entered.");
            }
            else
            {
                foreach (var exp in expenseList)
                {
                    Console.WriteLine($"Category : {exp.Category,-10} | Amount : ₹{exp.Amount}");
                    totalExpenses += exp.Amount; // [Add this item's cost to the total]
                }
            }
            Console.WriteLine();

            // [Print the final summary]
            Console.WriteLine("------ Expense Summary ------");
            Console.WriteLine($"Total Expenses     : ₹{totalExpenses}");
            Console.WriteLine($"Number of Expenses : {expenseList.Count}");
            Console.WriteLine();

            // [Prevent the console window from closing immediately]
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
