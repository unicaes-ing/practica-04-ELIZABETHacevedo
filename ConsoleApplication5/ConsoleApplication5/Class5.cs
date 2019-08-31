using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Class5
    {
        const string password = "contrasenna";
        int intento = 0;
        string contra,pista;
        public void eje1()
        {
            do
            {
                Console.WriteLine("intento {0}",intento+1);
                Console.WriteLine("ingrese contrasenna");
                contra = Console.ReadLine();
                if (contra.Equals(password))
                {
                    Console.WriteLine(":}");
                    break;
                }
                else
                {
                    pista = string.Concat(pista, password[intento]);
                    intento++;
                    Console.WriteLine("pista "+ pista);
                }

            } while (intento <3);

            if (contra.Equals(password))
            {

            }
            else
            {
                Console.WriteLine(":(");
            }
        }

    }
}
