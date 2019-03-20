using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace Aplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicios Obj = new Ejercicios();
            Console.WriteLine("Selecciones ejercicio a calificar");
            Console.WriteLine("1----Ejercicio 1");
            Console.WriteLine("2----Ejercicio 2");
            Console.WriteLine("3----Ejercicio 3");
            Console.WriteLine("4----Ejercicio 4");
            int n = int.Parse(Console.ReadLine());

            if(n==1){
                Obj.Ejercicio1();
                Console.ReadKey();
            }
            else if (n == 2)
            {
                Obj.Ejercicio2();
                Console.ReadKey();
            }
            else if (n == 3)
            {
                Obj.Ejercicio3();
                Console.ReadKey();
            }
            else if (n == 4)
            {
                Obj.Ejercicio4();
                Console.ReadKey();
            }
            else  
            {
                Console.WriteLine("Error");
            }
        }
    }
}
