using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Class4
    {
        int opcion;
        double venta, total, boni;

        public void eje1()
        {
            do
            {
                Console.WriteLine("ingrese venta [-1] para salir");
                do
                {
                    if (double.TryParse(Console.ReadLine(),out venta)&& venta >-2)
                    {
                        break;
                    }
                    Console.WriteLine("intentelo de nuevo");

                } while (true);
                if(venta!= -1)
                {
                    total = total + venta;
                }
            } while (venta != -1);

            boni = total * 0.05;
            Console.WriteLine("el total de ventas es {0}",total);
            Console.WriteLine("bonificaciones del 5% {0}",boni);
            Console.WriteLine("total general con bonificaciones {0}",(total+boni));

        }




    }
}
