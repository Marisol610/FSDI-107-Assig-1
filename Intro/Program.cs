using System;

namespace Intro
{
    class Program
    {
        // GLOBAL VARIABLES THAT CAN BE ACCESSED THROUGHT FUNCTIONS
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Program p= new Program();
            p.test();
            p.handleExc();

            int res = p.GreaterNumber(23, 94);
            System.Console.WriteLine(res);

            p.HomeWork();
        }

        void HomeWork()
        {

            for(int i=50; i >34; i--)
            
            {
                if(i !=37 && i !=43){
                    System.Console.WriteLine(i);
               }
            }
        }
// identify the bigger/ greater number
            //amd return it
        int GreaterNumber(int num1, int num2)
        {
            
            if(num1 > num2)
            {
                return num1;

            }
            else
            {
               return num2; 
            }
                
        }

      



        void handleExc()
        {
            try
            {
            string inputVal ="123a";
            decimal price =Decimal.Parse(inputVal); // will parse string into decimal
            System.Console.WriteLine(price);
        }
        catch(Exception ex)
        {
            System.Console.WriteLine("Error: Provided price is not a number");
            System.Console.WriteLine(ex.Message);
        }

        // here below
        }
        void test()
        {
            Console.WriteLine("I'm a function");
           // variables types
           // strong type language, this means when you declare a variable  you are not allowed to hold anythimg else in the variable
           string name= "Marisol";
           string last ="Rodriguez";
           int age= 34;
           float distance = 34.43f; // hold numbers with decimal places, use for anything else
           decimal total = 99.32m; // use decimal when refering to money
           bool found = false;

           // mathematical operations
           Console.WriteLine(21 + 21);
            System.Console.WriteLine(213- 12);
            System.Console.WriteLine(32 * 2);
            System.Console.WriteLine(900/ 92);

            // if statement
            if(age< 99) 
            {
                System.Console.WriteLine(name + "you are still young!");
            }
            else
            {
                System.Console.WriteLine("Sorry" + name + "you are getting old");
            }

            // for loop
            // want: nums from 0 to 10, except #3
            for(int i=0; i >11; i++)
            
            {
                if(i !=3 && i !=7){
                    System.Console.WriteLine(i);
               }
                
            }


        }
    }
}
