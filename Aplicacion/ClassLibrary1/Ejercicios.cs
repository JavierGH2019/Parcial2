using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Ejercicios
    {
        public void Ejercicio1(){
            int n1 = 0,n2=0;

            Console.WriteLine("Por favor ingrese el primer numero");
              n1 = int.Parse(Console.ReadLine());

            if(n1==0){
                Console.WriteLine("El producto de 0 por cualquier numero es 0");               
            }
            else
            {
                Console.WriteLine("Por favor digite otro numero. ");
                  n2 = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El producto de "+n1+"*"+n2+"es=: "+(n1*n2));
    }
        public void Ejercicio2() {
            int n = 0,n1=0,n2=0;
            Console.WriteLine("Digite 2");
           n=int.Parse(Console.ReadLine());
            if(n==2){
                Console.WriteLine("Digite un primer numero ");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite un segundo numero ");
                n2 = int.Parse(Console.ReadLine());

                if (n2 == 0)
                {
                    Console.WriteLine("error no se puede dividir entre 0");
                }
                else {
                    Console.WriteLine("Resultado "+(n1/n2));
                }
            }
        
        }
        public void Ejercicio3() {
            int n = 0;
            Console.WriteLine("Presione3");
            n = int.Parse(Console.ReadLine());

            if(n==3){
                int i=0;
                 
                string[] nombre=new string[5];
                for (i = 0; i < 5;i++ )
                {
                    Console.WriteLine("Digite nombre"+(i+1));
                    nombre[i] = Console.ReadLine();
                    
                }
                for (i = 0; i < 5; i++)
                {
                    Console.WriteLine("Hola-----"+nombre[i]);                  

                }


            }
        }
        public void Ejercicio4() {
            int n,i=1,i2=0;
            string[] edad=new string[5];
            Console.WriteLine("Ingrese numero 4");
            n = int.Parse(Console.ReadLine());

            if(n==4){
                do
                {
                    Console.WriteLine("Digitela edad del alumno: " + i);
                    edad[i - 1] = Console.ReadLine();
                    i++;
                }
                while (i < 6);
                do
                {
                    Console.WriteLine("Edad-"+(i2+1)+"=" + edad[i2]+"años");
                    i2++;
                     
                }
                while (i2 < 5);

            }

        }
         

    }
}
