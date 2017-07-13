using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Tom Tsiliopoulos
 * Date: July 11, 2017
 * Description: This is the driver class for my project
 * Version: 0.2 - Modified Constructor 
 */

namespace COMP123_S2017_Lesson9A
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperVillain superVillain = new SuperVillain("SuperVillain Dude",100);
            superVillain.Powers.Add(new Power("Teleportation",50));
            superVillain.Powers.Add(new Power("Phasing", 40));
            superVillain.Powers.Add(new Power("Invisibility", 30));
            Console.WriteLine(superVillain.ToString());
            Console.WriteLine("Malice: " + superVillain.Malice);
        }
    }
}
