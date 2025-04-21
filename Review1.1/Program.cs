using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoledocumation
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Information Input");

            Console.WriteLine("what is your first name?");//string variable input for firstname 
            string firstname = Console.ReadLine();

            Console.WriteLine("what is your last name?");//string variable input for lastname
            string lastname = Console.ReadLine();


            Console.WriteLine("Enter your age:");//string variable input for age
            int age = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("What is your favorate color?");//string variable input or color
            string color = Console.ReadLine();

            //Printing the variable (firstname, lastname, age, color) to show the input value
            Console.WriteLine("Hello," + firstname+ " " + lastname + "! You are  "+ age +  " year old and your favorite color is " + color);

        }

    }

}
