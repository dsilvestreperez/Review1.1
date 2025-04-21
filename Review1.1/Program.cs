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

            Console.WriteLine("what is your first name?");// input firstname
            string firstname = Console.ReadLine();//first name

            Console.WriteLine("what is your last name?");//input lastname
            string lastname = Console.ReadLine();//last name


            Console.WriteLine("Enter your age:");//input age
            int age = Convert.ToInt32(Console.ReadLine());// age


            Console.WriteLine("What is your favorate color?");//input color 
            string color = Console.ReadLine();// color


            Console.WriteLine("Hello," + firstname + lastname + "! You are" + age + " year old and your favorite color is " + color);// output


        }

    }

}
