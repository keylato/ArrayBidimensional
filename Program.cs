using System;

namespace array_bidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] numeros = new int [3,3] {{1,3,5}, {2,4,6}, {3, 5,9}};

            Console.Write(numeros[0,0]);
            Console.Write(numeros[0,1]);
            Console.Write(numeros[0,2 + \n ]);
            Console.Write(numeros[1,0]);
            Console.Write(numeros[1,1]);
            Console.Write(numeros[1,2 + \n ]);
            Console.Write(numeros[2,0]);
            Console.Write(numeros[2,1]);
            Console.Write(numeros[2,2+ \n ]);

            int cadro1= {{0,0,1,1,2,2}};
            int cuadro2= {0,1,1,2,2,0}};
            int cuadro3= {{0,2,1,0,2,1}};
            int cuadro4= {{0,2,1,1,2,0}};
            int cuadro5 = {{0,1,1,2,2,1}};
            int cuandro6 ={{0,2,1,1,2,0}};

            int suma= (cuadro1 + cuadro2 + cuadro3);
            int resta= (suma + cuadro4 -cuadro5 -cuandro6);

            Console.Writeline(resta);




        }


    }
}
