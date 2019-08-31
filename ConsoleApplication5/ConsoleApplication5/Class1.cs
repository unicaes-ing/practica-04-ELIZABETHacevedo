using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Class1
    {

        public void eje1()
        {
            decimal sueldo,prom,total=0;
            
            bool algo = true;
            for (int i = 0; i < 20; i++)
            {   
                do
                {
                    Console.WriteLine("{0} ingrese su sueldo:",i+1);
                   if(decimal.TryParse(Console.ReadLine(),out sueldo) && sueldo>0){
                       total = total + sueldo;
                       algo = false;
                   }
                   else
                   {
                       Console.WriteLine("el dato ingresado es incorrecto");
                   }
                    
                } while (algo);
            }

            Console.WriteLine("el total de sueldos es {0}",total.ToString("C2"));
            prom=total/20;
            Console.WriteLine("promedio de sueldos es {0}",prom.ToString("C2"));
            Console.ReadKey();
        }





    }
}
