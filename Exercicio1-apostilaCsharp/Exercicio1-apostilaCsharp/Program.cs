using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_apostilaCsharp
{
    class Program
    {
        static void Main(string[] args)

        {
            int idade = 16; bool brasileiro = true;
            if ((idade >=16) && (brasileiro == true))
            {
                Console.WriteLine("pode votar");
            }
            else
            {
                Console.WriteLine("não pode votar");
            }

            

            Console.ReadKey();



        }
    }
}
