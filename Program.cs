using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    struct Program
    {
        static void Main(string[] args)
        {
            int i;
            string[] Names = new string[15];
            Console.WriteLine("Enter 10 names: ");
            for( i = 0; i < 10; i++)
            {
                Names[i] = Console.ReadLine();
            }
            Console.WriteLine("The names are as follows: ");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(Names[i]);
            }
            
            // for adding a name to the array we are shifting the elements
            
            for (i = 9; i >0; i--)
            {
                Names[i+1] = Names[i];
            }
            
            Console.WriteLine("Enter the name for second position: ");
            Names[1]=Console.ReadLine();
            
            // shifting the elements for removing the name
            
            for (i = 3; i <11; i++)
            {
                Names[i-1] = Names[i];
            }
            Console.WriteLine("The names are as follows: after appending");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(Names[i]);
            }

            string Names1 = String.Join(",", Names);

            Console.WriteLine(Names1);            

        }
    }
}
