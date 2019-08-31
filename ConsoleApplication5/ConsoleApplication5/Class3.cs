using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Class3
    {
        public void eje3()
        {
            int numVocales=0;
            string nombre;
            Console.WriteLine("escriba su nombre:");
            nombre = Console.ReadLine();
            nombre=nombre.ToUpper();

            for (int i = 0; i < nombre.Length; i++)
            {
                if(i.Equals("A") || i.Equals("E") || i.Equals("I") || i.Equals("O") || i.Equals("U"))
                {
                    numVocales = numVocales + 1;
                }
            }
            Console.WriteLine("el total de vovcales es {0}",numVocales);
            Console.ReadKey();







        }
    }
}
