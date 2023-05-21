using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Note: constructors call Factory Method
            Computer[] computers = new Computer[2];

            computers[0] = new Hardware();
            computers[1] = new Software();

            foreach(Computer computer in computers)
            {
                Console.WriteLine("\n" + computer.GetType().Name + "--");
                foreach (Development development in computer.Developments)
                {
                    Console.WriteLine(" " + development.GetType().Name);
                }
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}
