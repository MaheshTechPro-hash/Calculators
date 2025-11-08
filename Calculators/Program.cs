using System;

namespace CalculatorApp
{

    class Calculator
{
    static void Main(String[] args)
    {
        double num1, num2, result;
        char op;


        Console.WriteLine("Enter first number:");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter an operator (+, -, *, /):");
        op = Convert.ToChar(Console.ReadLine());


        switch(op)
            {


            case '+':
                result = num1 + num2;
                Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
                break;


            case '-':
                result = num1 - num2;
                Console.WriteLine("{0} - {1} = {2}", num1, num2, result);
                break;
            case '*':
                result = num1 * num2;
                Console.WriteLine("{0} * {1} = {2}", num1, num2, result);
                break;


            case '/':
                if (num2 == 0)
                {
                    Console.WriteLine(" Error: Division by zero is not allowed.");
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine("{0} / {1} = {2}", num1, num2, result);
                }
                break;

                default:
                Console.WriteLine("Error: Invalid operator");
                break;


            }
        }
    }
}
