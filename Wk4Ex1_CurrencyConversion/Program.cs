using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Wk4Ex1_CurrencyConversion
{
    internal class Program
    {
        static double HandleDoubleInput(string aPrompt, string anErrorMessage = "Your input is invalid. Please enter a valid number input.")
        {
            // initialize return value
            double returnValue = Double.MaxValue;

            // processing

            // start of a do while loop
            do
            {
                // A try catch to ensure the user input is valid
                try
                {
                    // Ask user to input a number
                    Console.Write(aPrompt);
                    // Convert user input to a double, collect input from user and store it in the returnValue
                    returnValue = Convert.ToDouble(Console.ReadLine());
                }
                // if that doesn't work, output an error message
                catch (Exception e)
                {
                    // output an error message
                    Console.WriteLine(anErrorMessage);
                }
            }
            // loop until returnValue has a different value
            while (returnValue == Double.MaxValue);
            // return returnValue
            return returnValue;
        }

        static int HandleIntInput(string aPrompt, string anErrorMessage = "Your input is invalid. Please enter a whole number.")
        {
            // initialize return value
            int returnValue = Int32.MaxValue;

            // processing

            // start of a do while loop
            do
            {
                // A try catch to ensure the user input is valid
                try
                {
                    // Ask user to input a number
                    Console.Write(aPrompt);
                    // Convert user input to a double, collect input from user and store it in the returnValue
                    returnValue = Convert.ToInt32(Console.ReadLine());
                }
                // if that doesn't work, output an error message
                catch (Exception e)
                {
                    // output an error message
                    Console.WriteLine(anErrorMessage);
                }
            }
            // loop until returnValue has a different value
            while (returnValue == Int32.MaxValue);
            // return returnValue
            return returnValue;
        }

        static double ConvertToUSD(double amount, int fromCurrency, string errorMessage = "It seems there was an error converting your value. Please close the program and try again.")
        {
            // initialize return value
            double returnValue = Double.MaxValue;


            // processing


            // initialize conversion rate variables
            double usdToEurRate = 0.96;     // declare and initialize double usdToEurRate variable to the rate 0.96
            double usdToJpyRate = 152.20;     // declare and initialize double usdToJpyRate variable to the rate 152.20

            switch (fromCurrency)
            {
                // case to convert USD to USD. run if fromCurrency = 1
                case 1: // fromCurrency = USD ; toCurrency is USD
                    // keep USD the same
                    amount *= 1;
                    // Jump out of switch case here
                    break;


                // case to convert EUR to USD. run if fromCurrency = 2

                case 2: // fromCurrency = EUR ; toCurrency is USD
                    // divide amount(EUR) by the USD-to-EUR rate
                    amount /= usdToEurRate;
                    // Jump out of switch case here
                    break;


                // case to convert JPY to USD. run if fromCurrency = 3

                case 3: // fromCurrency = JPY ; toCurrency is USD
                    // divide amount(JPY) by USD-to-JPY rate
                    amount /= usdToJpyRate;
                    // Jump out of switch case here
                    break;


                // run default value if none of the others are true
                default:
                    // output the error message
                    Console.WriteLine(errorMessage);
                    // Jump out of switch case here
                    break;
            }

            // convert return value to amount
            returnValue = amount;


            // return returnValue
            return returnValue;
        }


        static double ConvertToEUR(double amount, int fromCurrency, string errorMessage = "It seems there was an error converting your value. Please close the program and try again.")
        {
            // initialize return value
            double returnValue = Double.MaxValue;


            // processing


            // initialize conversion rate variables
            double usdToEurRate = 0.96;     // declare and initialize double usdToEurRate variable to the rate 0.96
            double eurToJpyRate = 158.18;       // declare and initialize double eurToJpyRate variable to the rate 158.18

            switch (fromCurrency)
            {
                // case to convert USD to EUR. run if fromCurrency = 1

                case 1: // fromCurrency = USD ; toCurrency is EUR
                    // multiply amount(USD) by USD to EUR rate
                    amount *= usdToEurRate;
                    // Jump out of switch case here
                    break;


                // case to convert EUR to EUR. run if fromCurrency = 2

                case 2: // fromCurrency = EUR ; toCurrency is EUR
                    // keep EUR the same
                    amount *= 1;
                    // Jump out of switch case here
                    break;


                // case to convert JPY to EUR. run if fromCurrency = 3

                case 3: // fromCurrency = JPY ; toCurrency is EUR
                    // divide amount(Jpy) by EUR-to-JPY rate
                    amount /= eurToJpyRate;
                    // Jump out of switch case here
                    break;


                // run default value if none of the others are true
                default:
                    // output the error message
                    Console.WriteLine(errorMessage);
                    // Jump out of switch case here
                    break;
            }

            // convert return value to amount
            returnValue = amount;


            // return returnValue
            return returnValue;
        }


        static double ConvertToJPY(double amount, int fromCurrency, string errorMessage = "It seems there was an error converting your value. Please close the program and try again.")
        {
            // initialize return value
            double returnValue = Double.MaxValue;


            // processing


            // initialize conversion rate variables
            double usdToEurRate = 0.96;     // declare and initialize double usdToEurRate variable to the rate 0.96
            double usdToJpyRate = 152.20;     // declare and initialize double usdToJpyRate variable to the rate 152.20
            double eurToJpyRate = 158.18;       // declare and initialize double eurToJpyRate variable to the rate 158.18

            switch (fromCurrency)
            {
                // case to convert USD to JPY. run if fromCurrency = 1

                case 1: // fromCurrency = USD ; toCurrency is JPY
                    // first convert USD to EUR
                    // multiply amount(USD) by USD to EUR rate
                    amount *= usdToEurRate;

                    // Then convert EUR to JPY
                    // multiply amount(EUR) by EUR-toJPY rate
                    amount *= eurToJpyRate;
                    // Jump out of switch case here
                    break;


                // case to convert EUR to JPY. run if fromCurrency = 2

                case 2: // fromCurrency = EUR ; toCurrency is JPY
                    // multiply amount(EUR) by EUR-toJPY rate
                    amount *= eurToJpyRate;
                    // Jump out of switch case here
                    break;


                // case to convert JPY to JPY. run if fromCurrency = 3

                case 3: // fromCurrency = JPY ; toCurrency is JPY
                    // keep JPY the same
                    amount *= 1;
                    // Jump out of switch case here
                    break;


                // run default value if none of the others are true

                default:
                    // output the error message
                    Console.WriteLine(errorMessage);
                    // Jump out of switch case here
                    break;
            }

            // convert return value to amount
            returnValue = amount;


            // return returnValue
            return returnValue;
        }


        static void Main(string[] args)
        {
            // Goal: Convert currency values using modular methods. Values: USD, EUR, JPY.
            // Allow user to input the amount they want to convert
            // Allow user to choose which currency they want to convert to.

            // Delcare Variables
            // Input Variables
            double amount = Double.MaxValue;        // Declare a double variable for amount user wants to convert
            int startCurrency = Int32.MaxValue;        // Declare a selection variable for their choice of currency to input
            int convertionCurrency = Int32.MaxValue;        // Declare a selection variable for their choice of currency to convert the amount to
            // Output Variables
            double convertedAmount = Double.MaxValue;       // Declare variable to hold the amount once it is converted


            // Get the selection of currency the user is inputting. Account for possible errors with a do while loop.
            do
            {
                // Output the choices and their number values
                Console.WriteLine("Select the currency of your input amount:");
                // Output to tell the user they can type 1 for USD
                Console.WriteLine("1. United States Dollar (USD)");
                // Output to tell the user they can type 2 for EUR
                Console.WriteLine("2. Euro (EUR)");
                // Output to tell the user they can type 3 for JPY
                Console.WriteLine("3. Japanese Yen (JPY)");

                // Call the try catch in the Interger Conversion module
                startCurrency = HandleIntInput("Your starting currency is (1-3): ", "An error occured. Please ensure you enter a valid whole number.");

                // If the selection isn't between 1 and 3, change the input back to the while evaluation number to have them try again
                if (!(startCurrency >= 1 && startCurrency <= 3))
                {
                    // output a message to prompt user to re-enter the value as a number from 1 to 3
                    Console.WriteLine("Please input a value between 1 and 3.");
                    // set selection to the max integer value
                    startCurrency = Int32.MaxValue;
                }
            }
            // continue loop while the selection is the max integer value
            while (startCurrency == Int32.MaxValue);



            // Call the try catch in the Double Conversion module
            // Make amount equal the return value of the module
            amount = HandleDoubleInput("How much money would you like to see the conversion of? ");

            
            // Get the selection of currency to convert to from the user. Account for possible errors with a do while loop.
            do
            {
                // Output the choices and their number values
                Console.WriteLine("Select a currency to convert your amount to:");
                // Output to tell the user they can type 1 for USD
                Console.WriteLine("1. United States Dollar (USD)");
                // Output to tell the user they can type 2 for EUR
                Console.WriteLine("2. Euro (EUR)");
                // Output to tell the user they can type 3 for JPY
                Console.WriteLine("3. Japanese Yen (JPY)");

                // Call the try catch in the Interger Conversion module
                // Make conversionCurrency equal the return value of the module
                convertionCurrency = HandleIntInput("Your desired currency choice (1-3): ", "An error occured. Please ensure you enter a valid whole number.");

                // If the selection isn't between 1 and 3, change the input back to the while evaluation number to have them try again
                if (!(convertionCurrency >= 1 && convertionCurrency <= 3))
                {
                    // output a message to prompt user to re-enter the value as a number from 1 to 3
                    Console.WriteLine("Please input a value between 1 and 3.");
                    // set selection to the max integer value
                    convertionCurrency = Int32.MaxValue;
                }
            }
            // continue loop while the selection is the max integer value
            while(convertionCurrency == Int32.MaxValue);


            switch (convertionCurrency)
            {
                // Run this case if selection = 1
                case 1:
                    // Tell the user the amount they input and what currency they chose to convert it to
                    Console.WriteLine($"You are converting {amount:C2} to USD.");
                    // convert the amount to USD
                    convertedAmount = ConvertToUSD(amount, startCurrency);
                    // Output the converted value
                    Console.WriteLine($"The converted amount is {convertedAmount:C2}.");
                    // Jump out of switch here.
                    break;


                // Run this case if selection = 1
                case 2:
                    // Tell the user the amount they input and what currency they chose to convert it to
                    Console.WriteLine($"You are converting {amount:C2} to EUR.");
                    // convert the amount to USD
                    convertedAmount = ConvertToEUR(amount, startCurrency);
                    // Output the converted value
                    Console.WriteLine($"The converted amount is {convertedAmount:C2}.");
                    // Jump out of switch here.
                    break;


                // Run this case if selection = 1
                case 3:
                    // Tell the user the amount they input and what currency they chose to convert it to
                    Console.WriteLine($"You are converting {amount:C2} to JPY.");
                    // convert the amount to USD
                    convertedAmount = ConvertToJPY(amount, startCurrency);
                    // Output the converted value
                    Console.WriteLine($"The converted amount is {convertedAmount:C2}.");
                    // Jump out of switch here.
                    break;


                default:
                    // Output a polite message in case of unforseen error.
                    Console.WriteLine("It seems something went wrong on our end. Please close the program and try again.");
                    // Jump out of switch here.
                    break;
            }

            // Thank user for using the program
            Console.WriteLine("Thank you for using this currency conversion program! Come again!");

            // Pause at the end of program for user to read
            Console.ReadLine();
        }
    }
}
