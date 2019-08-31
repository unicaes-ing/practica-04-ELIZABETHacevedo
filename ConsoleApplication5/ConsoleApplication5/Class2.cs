using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Class2
    {

        public void eje2()
        {
            int numEstudiantes,asistencia;
            double calificaciones,apr=0,des=0;
            bool algo = true,algo2=true;
            do
            {
                Console.WriteLine("ingrese cantidad de estudiantes en el curso:");
                if(int.TryParse(Console.ReadLine(),out numEstudiantes) && numEstudiantes>0){

                    algo = false;
                }
                else
                {
                    Console.WriteLine("dato erroneo intentelo de nuevo");
                }
            } while (algo);

            for (int i  = 0; i  < numEstudiantes; i ++)
            {
                algo = true;
               
                do
                {
                    Console.WriteLine("ingrese nota {0}:", i + 1);
                    if (double.TryParse(Console.ReadLine(), out calificaciones) && calificaciones>-1 && calificaciones<11)
                    {
                        algo2 = true;
                        do
                        {
                            Console.WriteLine("ingrese asistencia de estudiante {0}:",i+1);
                            if (int.TryParse(Console.ReadLine(), out asistencia) && asistencia>-1 && asistencia <101)
                            {

                                if(calificaciones>=7.0 && asistencia >=75){
                                    apr = apr + 1;
                                }else
                                {
                                    des = des + 1;
                                }




                                algo2 = false;
                            }
                            else
                            {
                                Console.WriteLine("dato erroneo intentelo de nuevo");
                            }
                        } while (algo2);















                        algo = false;
                    }
                    else
                    {
                        Console.WriteLine("dato erroneo intentelo de nuevo");
                    }
                } while (algo);




            }

            Console.WriteLine("la cantidad de estudiantes aprobados es {0}",apr);
            Console.WriteLine("la cantidad de estudiantes reprobados es {0}",des);
            Console.ReadKey();
        }


    }
}
