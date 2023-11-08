using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id = 0;
            string empName = "";
            char empGender = ' ';
            double empSal = 0;
            DateTime empDOJ = new DateTime(1,1,1);
            int tax;
            try
            {
                Console.WriteLine("Enter Employee ID");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Name");
                empName = (Console.ReadLine());
                Console.WriteLine("Enter Employee Gender");
                empGender = char.Parse(Console.ReadLine().ToUpper());
                Console.WriteLine("Enter Employee Salary");
                empSal = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Date of Joining");
                empDOJ = DateTime.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! " + ex.Message);
            }
            Console.WriteLine("ID \t Employee Name \t Employee Gender \t Employee Salary \t DOJ");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t",id, empName, empGender, empSal, empDOJ);
            if (empSal > 90000)
            {
                tax = 30;
            }
            else
            {
                tax = 15;
            }
            Console.WriteLine("You have to pay: "+tax+"% tax");
            Console.ReadKey();
        }
    }
}
