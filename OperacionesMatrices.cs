using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuEstudiantil
{
    internal class OperacionesMatrices
    {
        public static void MenuMatrices(int[,] matriz,int tamanio)
        {
            try
            {

                Console.WriteLine(" --- Matrices ---");
                Console.WriteLine(" 1) Mostrar Matriz");
                Console.WriteLine(" 2) Diagonal Princiapal");
                Console.WriteLine(" 3) Diagonal Secundaria");
                Console.WriteLine(" 4) Triangular Inferior");
                Console.WriteLine(" 5) Triangular Superior");
                Console.WriteLine(" 6) Triangular Inferior secundaria");
                Console.WriteLine(" 7) Triangular Superior secundaria");
                Console.WriteLine(" 8) Suma Matriz");
                Console.WriteLine(" 9) Volver a Ingresar tamaño del matriz");
                Console.WriteLine(" 10) Regresar Menu principal");
                Console.WriteLine("Elige una de las opciones");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        MostrarMatriz(matriz,tamanio);
                        break;
                    case 2:
                        DiagonalPrincipal(matriz, tamanio);
                        break;
                    case 3:
                        DiagonalSecundarial(matriz, tamanio);
                        break;
                    case 4:
                        TriangularInferior(matriz, tamanio);
                        break;
                    case 5:
                        TriangularSuperior(matriz, tamanio);
                        break;
                    case 6:
                        TriangularInferiorSec(matriz, tamanio);
                        break;
                    case 7:
                        TriangularSuperiorSec(matriz, tamanio);
                        break;
                    case 8:
                        SumaMatriz(matriz, tamanio);
                        break;
                    case 9:
                        Console.Clear();
                        Menu.MenuSecundario(2);
                        break;
                    case 10:
                        Console.Clear();
                        Menu.MenuPrincipal();
                        break;

                    default:
                        Console.WriteLine("Elige Correctamente la opcion");
                        MenuMatrices(matriz,tamanio);
                        break;

                }





            }
            catch (Exception ex)
            {
                Console.WriteLine("Se permiten solo Numeros");
                MenuMatrices(matriz, tamanio);
            }

        }
        static void MostrarMatriz(int[,] matriz,int tamanio)
        {
            Console.WriteLine("Vector Original:");
            for (int fila = 0; fila < tamanio; fila++)
            {
                for (int columna = 0; columna < tamanio; columna++)
                {
                    Console.Write(matriz[fila, columna] + "\t ");
                }
                Console.WriteLine();   
            }
  
            MenuMatrices(matriz, tamanio);
            Console.ReadLine();
        }
        static void DiagonalPrincipal(int[,] matriz, int tamanio)
        {

            Console.WriteLine("Diagonal Princiapal");
            for (int fila = 0; fila < tamanio; fila++)
            {
                for (int columna = 0; columna < tamanio; columna++)
                {
                    if (fila == columna)
                    {
                        Console.Write(matriz[fila, columna] + "\t ");

                    }
                    Console.Write("\t");
                }
                Console.WriteLine("");
            }

            MenuMatrices(matriz, tamanio);
            Console.ReadLine();
        }
        static void DiagonalSecundarial(int[,] matriz, int tamanio)
        {

            Console.WriteLine("Diagonal Secundaria");
            for (int fila = 0; fila < tamanio; fila++)
            {
                for (int columna = 0; columna < tamanio; columna++)
                {
                    if ((fila + columna) == tamanio - 1)
                    {
                        Console.Write(matriz[fila, columna] + "\t ");

                    }
                    Console.Write("\t");
                }
                Console.WriteLine("");
            }

            MenuMatrices(matriz, tamanio);
            Console.ReadLine();
        }
        static void TriangularInferior(int[,] matriz, int tamanio)
        {

            Console.WriteLine("Triangular Inferior ");

            for (int fila = 0; fila < tamanio; fila++)
            {
                for (int columna = 0; columna < tamanio; columna++)
                {
                    if (columna > fila)
                    {
                        Console.Write(matriz[fila, columna] );

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    Console.Write("\t");
                }
                Console.WriteLine("");
            }


            MenuMatrices(matriz, tamanio);
            Console.ReadLine();


        }
        static void TriangularSuperior(int[,] matriz, int tamanio)
        {

            Console.WriteLine(" Triangular Superior  ");

            for (int fila = 0; fila < tamanio; fila++)
            {
                for (int columna = 0; columna < tamanio  ; columna++)
                {

                    if (columna < fila)
                    {
                        Console.Write(matriz[fila, columna]);

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    Console.Write("\t"); Console.Write("\t");
                }
                Console.WriteLine("");
            }


            MenuMatrices(matriz, tamanio);
            Console.ReadLine();
        }
        static void TriangularInferiorSec(int[,] matriz, int tamanio)
        {
            Console.WriteLine("Triangular inferior secundaria");

            int num = tamanio - 1;
            for (int fila = 0; fila < tamanio - 1; fila++)
            {
                for (int columna = 0; columna < num; columna++)
                {
                  
                        Console.Write(matriz[fila, columna]);
                   
                    Console.Write("\t");
                }
                num--;
                Console.WriteLine("");
            }

            MenuMatrices(matriz, tamanio);
            Console.ReadLine();
           


        }
        static void TriangularSuperiorSec(int[,] matriz, int tamanio)
        {

            Console.WriteLine("Triangular superior secundaria");

            int num = tamanio - 1;
            for (int fila = 1; fila < tamanio; fila++)
            {
                Console.WriteLine("");
                for (int columna = num; columna < tamanio; columna++)
                {

                    Console.Write(matriz[fila, columna]);
                   


                    Console.Write("\t");
                }
               num--;
                Console.WriteLine("");
            }

            MenuMatrices(matriz, tamanio);
            Console.ReadLine();
        }

        static void SumaMatriz(int[,] matriz, int tamanio)
        {

            Console.WriteLine("Suma matriz");

            int suma;
            for (int fila = 0; fila < tamanio; fila++)
            {
                suma = 0; 
                for (int columna = 0; columna < tamanio; columna++)
                {
                    suma += matriz[columna,fila];
                }
             
                Console.Write(suma + " ");
            }
            Console.WriteLine(" ");
            MenuMatrices(matriz, tamanio);
            Console.ReadLine();
        }
    }
}
