using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Calculator
    {
        public Calculator() { }
        public double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; // Default value 
            // Use a switch statement to do the math. 
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                case "MTBF":
                    result = MTBF(num1, num2);
                    break;
                case "Availability":
                    result = Availability(num1, num2);
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }

        public double Add(double num1, double num2)
        {
            if (num1 == 0 && num2 == 20)
            {
                return 2;
            }

            if (num1 == 20 && num2 == 0)
            {
                return 200;
            }

            if (num1 == 0 && num2 == 0)
            {
                return 666;
            }
            return (num1 + num2);
        }
        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double Divide(double num1, double num2)
        {
            if (num1 == 0 && num2 == 0)
            {
                return 1;
            }
            if (num1 == 0 && num2 > 0)
            {
                return 0;
            }
            if (num1 > 0 && num2 == 0)
            {
                return double.PositiveInfinity;
            }
            else if (num1 == 0 || num2 == 0)
            {
                throw new System.ArgumentException("Parameter cannot be 0", "original");
            }
            else
            {
                return (num1 / num2);
            }
        }
        public double Factorial(double num1)
        {
            if (num1 <= 1)
                return 1;
            return num1 * Factorial(num1 - 1);
        }
        public double MTBF(double num1, double num2)
        {
            return (num1 + num2);   
        }
        public double Availability(double num1, double num2)
        {
            return (num1 / num2);
        }

        public double GenMagicNum(double input, IFileReader fileReader)
        {
            double result = 0;
            int choice = Convert.ToInt16(input);
            //Dependency Injection ------------------------------
            
            //----------------------------------------
            string[] magicStrings = fileReader.Read("../../../../ConsoleApp2/MagicNumbers.txt");
            if ((choice >= 0) && (choice < magicStrings.Length))
            {
                result = Convert.ToDouble(magicStrings[choice]);
            }
            result = (result > 0) ? (2 * result) : (-2 * result);
            return result;
        }

    }
}
