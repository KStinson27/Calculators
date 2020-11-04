using System;
using System.Linq;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            do
            {

                Console.WriteLine("Select an calculator #: 1. Temperature Conversion, 2. Sales Tax, 3. Tip Calculator, 4. Group Bill Split or Press 5 to exit the program ");
                int choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        //Exercise 1 - Farenheight to Celsius

                        double temperatureFahrenheit;
                        double temperatureCelsius;

                        Console.WriteLine("What is the weather today? Enter the temperature in degrees (Fahrenheit): ");

                        temperatureFahrenheit = Int32.Parse(Console.ReadLine());
                        temperatureCelsius = (temperatureFahrenheit - 32) * 5 / 9;

                        Console.WriteLine($"You entered {temperatureFahrenheit} degrees Fahrenheit. The temperature in Celsius is {temperatureCelsius} degrees.");

                        break; 

                    case 2:
                        //Exercise 2 - Sales Tax

                        double productPrice;
                        double stateTax;
                        double salesTax;
                        double total;
                        double stateTaxConversion;

                        Console.WriteLine("Enter the price of your item");
                        productPrice = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("What is your state's sales tax?");
                        stateTax = Int32.Parse(Console.ReadLine());

                        stateTaxConversion = stateTax / 100;
                        salesTax = stateTaxConversion * productPrice;

                        total = salesTax + productPrice;

                        Console.WriteLine("The total cost of your item is {0:C2}", total);

                        break;

                    case 3:
                        //Exercise 3 - Tip Calculator

                        double billTotal;
                        double tipOwed;

                        Console.WriteLine("What is the total of your dining bill? ");
                        billTotal = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("What percent would you like to leave as a tip? ");
                        double tipChoice = Convert.ToDouble(Console.ReadLine());

                        double tipPercentage = tipChoice / 100;

                        tipOwed = billTotal * tipPercentage;

                        Console.WriteLine("The total of the tip would be {0:C2}.", tipOwed);

                        break;

                    case 4:
                        //Exercise 4 - Bill Dividends

                        double groupBillTotal;
                        double contributors;
                        double individualContributorTotal;

                        Console.WriteLine("How much is the group's total bill?");
                        groupBillTotal = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("How many people are splitting the bill? ");
                        contributors = Convert.ToDouble(Console.ReadLine());

                        individualContributorTotal = groupBillTotal / contributors;

                        Console.WriteLine("Each person will need to pay {0:C2}.", individualContributorTotal);

                        break;

                    case 5:

                        Console.WriteLine("Goodbye");
                        exit = true;
                        break;

                    default:

                        Console.WriteLine("Enter a valid number.");
                        break;
                }
                
            } while (exit != true);
        }
    }
}



