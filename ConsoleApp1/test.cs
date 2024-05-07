using csbemt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class test
    {
        static void Main(string[] args)
        { 
            ReadData Read = new ReadData();

            List<double> airfoil_alpha = new List<double>();
            List<double> airfoil_Cl = new List<double>();
            List<double> airfoil_Cd = new List<double>();

            Read.Airfoil_dat("C:\\Users\\LG\\Desktop\\5.07\\naca 0012.txt", airfoil_alpha, airfoil_Cl, airfoil_Cd);

            for(int i = 0; i < airfoil_Cl.Count; i++)
            {
                Console.Write(airfoil_alpha[i] + " ");
                Console.Write(airfoil_Cl[i] + " ");
                Console.WriteLine(airfoil_Cd[i]);
            }

        }

       
    }
}
