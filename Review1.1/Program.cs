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

            Console.WriteLine("what is your first name?");//the variable of your first name base info
            string firstname = Console.ReadLine();//the input of your first name 

            Console.WriteLine("what is your last name?");//the variable of your last name base info
            string lastname = Console.ReadLine();//the input of your last name


            Console.WriteLine("Enter your age:");//tne variable of your age
            int age = Convert.ToInt32(Console.ReadLine());// the input to put you age in


            Console.WriteLine("What is your favorate color?");//the varible to knwo your favorite color
            string color = Console.ReadLine();//  the input of your favorite colro

            //the display that will print out all the information in a sentance.
            Console.WriteLine("Hello," + firstname+ " " + lastname + "! You are  "+ age +  " year old and your favorite color is " + color);

        }

    }

}
