using System;
using static System.Console;

namespace Week6HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            welcomeStatement();

            a = magicNumber();
            b = magicNumber();
         

            findArea(a, b);


            Console.WriteLine("Your tax rate is " + localTaxRate());

        }      
        static void welcomeStatement() 
        {
            Console.WriteLine("Welcome to My Method Examples");
        
        }
        static int magicNumber() 
        {
            int secretNumber;
            Console.WriteLine("Enter a number");
            secretNumber =Convert.ToInt32(Console.ReadLine());
            return secretNumber;
        
        
        }
        static void findArea(int num1, int num2) 
        { 
            int total = num1 * num2;
            Console.WriteLine("Your total is " + total);
        
        
        }
        static int localTaxRate() 
        {
            int taxRate;
            Console.WriteLine("Enter your tax rate");
            taxRate = Convert.ToInt32(Console.ReadLine());
            return taxRate;
        
        
        }
        
       

    }
}
