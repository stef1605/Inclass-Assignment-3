using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Stefan_Inclass_Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input1;
                string input2;

                Vehicle Vehicle1 = new Vehicle();
                Console.Write("Please enter the registration number of your vehicle: ");
                input1 = Console.ReadLine();
                Console.Write("Please enter the color of your vehicle: ");
                input2 = Console.ReadLine();
                Vehicle1.v_dets(float.Parse(input1), input2);
                Console.Write("Registration Number: " + Vehicle1.reg_num() + "\n");
                Console.Write("Color: " + Vehicle1.get_color() + "\n");

            }
            catch
            {
                Console.WriteLine("Error Occured");
            }
        }
    }
}
