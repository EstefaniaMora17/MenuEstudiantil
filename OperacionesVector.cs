using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuEstudiantil
{
    public static class OperacionesVector
    {
    
        public static void MenuVectores(int[] vector)
        {
            try
            {

                Console.WriteLine(" --- Vectores ---");
                Console.WriteLine(" 1) Mostrar Vector");
                Console.WriteLine(" 2) Ordenar de menor a mayor");
                Console.WriteLine(" 3) Ordenar de mayor a menor");
                Console.WriteLine(" 4) Opernaciones Matematicas de dos Vectores ");
                Console.WriteLine(" 5) Volver a Ingresar tamaño del vector");
                Console.WriteLine(" 6) Regresar Menu principal");
                Console.WriteLine("Elige una de las opciones");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        MostrarVector(vector);
                        break;
                    case 2:
                        OrdenarMenorMayorVector(vector);
                        break;
                    case 3:
                        OrdenarMayorMenorVector(vector);
                        break;
                    case 4:
                        OperacionesMatematicas(vector);
                        break;
                    case 5:
                        Console.Clear();
                        Menu.MenuSecundario(1);
                        break;
                    case 6:
                        Console.Clear();
                        Menu.MenuPrincipal();
                        break;

                    default:
                        Console.WriteLine("Elige Correctamente la opcion");
                        MenuVectores(vector);
                        break;

                }





            }
            catch (Exception ex)
            {
                Console.WriteLine("Se permiten solo Numeros");
                MenuVectores(vector);
            }

        }
        static void MostrarVector(int[] vector)
        {
            Console.WriteLine("Vector Original:");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("\t" + vector[i]);
            }

            Console.WriteLine();
            MenuVectores(vector);
            Console.ReadLine();
        }
        static void OrdenarMenorMayorVector(int[] vector)
        {
            Console.WriteLine("Ordenar Vector Menor a Mayor: ");

            for (int i = 0; i < vector.Length - 1; i++)
            {
                for (int j = 0; j < vector.Length - i - 1; j++)
                {
                    // Comparamos elementos adyacentes
                    if (vector[j] > vector[j + 1])
                    {
                        // Si el elemento actual es mayor que el siguiente,
                        // los intercambiamos
                        int temp = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("\t" + vector[i]);
            }
       

            Console.WriteLine();
            MenuVectores(vector);
            Console.ReadLine();


        }
        static void OrdenarMayorMenorVector(int[] vector)
        {
            Console.WriteLine("Ordenar Vector Menor a Mayor: ");

            for (int i = 0; i < vector.Length - 1; i++)
            {
                for (int j = 0; j < vector.Length - i - 1; j++)
                {
                    // Comparamos elementos adyacentes
                    if (vector[j] < vector[j + 1])
                    {
                        // Si el elemento actual es mayor  que el siguiente,
                        // los intercambiamos
                        int temp = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("\t" + vector[i]);
            }
       
            Console.WriteLine();
            MenuVectores(vector);
            Console.ReadLine();
        }
        static void OperacionesMatematicas(int[] vector)
        {

         
           
            int[] vectorDos = new int[vector.Length];
            Random random = new Random();

            //variables de operacion matematicas y resultado
            int[] suma = new int[vectorDos.Length];
            int[] resta = new int[vectorDos.Length];
            int[] multiplicacion = new int[vectorDos.Length];
            int[] division = new int[vectorDos.Length];

            //llenar vector Dos con numeros aleatorios
            for (int i = 0; i < vectorDos.Length; i++)
            {
                vectorDos[i] = random.Next(99);

            }
         
            //mostrar vector principal
            Console.WriteLine("Vector Principal:");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("\t" + vector[i]);
            }

            Console.WriteLine();

            //mostrar Vector secundario
            Console.WriteLine("Vector Secundario:");
            for (int i = 0; i < vectorDos.Length; i++)
            {
                Console.Write("\t" + vectorDos[i]);
            }
            for (int i = 0; i < vectorDos.Length; i++)
            {
                suma[i] = vector[i] + vectorDos[i];
                resta[i] = vector[i] - vectorDos[i];
                multiplicacion[i] = vectorDos[i] * vectorDos[i];
                division[i] = vectorDos[i] / vectorDos[i];
            }


            visualizarOperaciones(vectorDos, suma, resta, multiplicacion, division);

            Console.WriteLine();
            MenuVectores(vector);
            Console.ReadLine();
        }
        static void visualizarOperaciones(int[]vector, int[] suma, int[] resta, int[] multiplicacion, int[] division)
        {
            Console.WriteLine();
            Console.WriteLine("La suma de los vecores es: ");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("\t" + suma[i]);
            }

            Console.WriteLine();

            Console.WriteLine("La resta de los vecores es: ");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("\t" + resta[i]);
            }
            Console.WriteLine();

            Console.WriteLine("La multiplicacion de los vecores es: ");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("\t"+ multiplicacion[i]);

            }
            Console.WriteLine();

            Console.WriteLine("La división de los vecores es: ");
            for (int i = 0; i < vector.Length; i++)
            {

                Console.Write("\t"  + division[i]);
            }
        }
    }
}
