using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Class6
    {
       

        public void eje1()
        {
            int canS=0,contador=0;
            double ventas,totalV=0,proV=0;
            canS = pedirNum(canS,"ingrese la cantidad de sucursales");
            double[] vTotalVentas = new double[canS];
            double[] vpromVentas = new double[canS];
            for (int i = 0; i < canS; i++)
            {
                Console.WriteLine("sucursal {0}",i+1);
                contador = 0;
                do
                {
                 
                    do
                    {
                        Console.WriteLine("ingrese la venta: [0]para salir");
                        if (double.TryParse(Console.ReadLine(),out ventas) && ventas>-1)
                        {
                            break;
                        }
                    } while (true);

                    if (ventas!=0)
                    {
                        contador++;
                        vTotalVentas[i] = vTotalVentas[i] + ventas;
                    }

                } while (ventas != 0);

                vpromVentas[i] = vTotalVentas[i] / contador;



            }
            for (int i = 0; i < canS; i++)
            {
                Console.WriteLine("sucursal {0} total venta: {1} promedio de ventas {2}",i+1,vTotalVentas[i],vpromVentas[i]);
                totalV = totalV + vTotalVentas[i];
            }
            Console.WriteLine("total de ventas: {0}",totalV.ToString("C2"));
            Console.WriteLine("promedio de ventas {0}",totalV/canS);

        }

        static int pedirNum(int num,string mensaje="ingrese un numero")
        {
            do
            {
                Console.WriteLine(mensaje);
                if (int.TryParse(Console.ReadLine(),out num))
                {
                    return num;
                }
            } while (true);
        }


       

        }
    }

