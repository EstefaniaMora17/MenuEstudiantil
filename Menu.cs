using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuEstudiantil
{
    public static class Menu
    {
       public static void MenuPrincipal()
        {
            try
            {
                int opcion;
                Console.WriteLine("---- Menu Principal ----");
                Console.WriteLine(" 1) Vectores");
                Console.WriteLine(" 2) Matrices ");
                Console.WriteLine(" 3) Listas");
                Console.WriteLine(" 4) Pila");
                Console.WriteLine("Ingrese una Opción ");
                opcion = int.Parse(Console.ReadLine());

                MenuSecundario(opcion);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se permiten solo Numeros");
                MenuPrincipal();
            }

        }

        public static void MenuSecundario(int opcion)
        {
            try
            {
                int seleccion;
                switch (opcion)
                {

                    case 1:

                        Console.WriteLine(" Ingrese el tamaño del vector");
                        int tamanio = int.Parse(Console.ReadLine());
                        int[] vector = new int[tamanio];
                        Random random = new Random();

                        for (int i = 0; i < vector.Length; i++)
                        {
                            vector[i] = random.Next(99);

                        }

                        OperacionesVector.MenuVectores(vector);
                        break;
                    case 2:

                        Console.WriteLine(" Ingrese el tamaño de la matriz");
                        int tamanioMatriz = int.Parse(Console.ReadLine());
                        int[,] matriz = new int[tamanioMatriz, tamanioMatriz];
                        Random rand = new Random();

                        for (int fila = 0; fila < tamanioMatriz; fila++)
                        {
                            for (int columna = 0; columna < tamanioMatriz; columna++)

                                matriz[fila, columna] = rand.Next(99);
                        }


                        OperacionesMatrices.MenuMatrices(matriz,tamanioMatriz);
                        break;
                    case 3:

                      
                        List<int> list = new List<int>();
                        string entrada;
                        
                        Console.WriteLine(" Ingrese datos a la lista... 'fin' para terminar.");
                        
                        while (true)
                        {
                            Console.Write("Ingresa un numero: ");
                            entrada = Console.ReadLine();

                            if (entrada.ToLower() == "fin")
                            {
                                break;
                            }
                            if (int.TryParse(entrada, out int numero))
                            {
                                list.Add(numero);
                            }
                            else
                            {
                                Console.WriteLine("Entrada no válida. Ingrese solo números.");
                            }
                           
                            
                        }

                        OperacionesListas.MenuListas(list);
                        break;
                    case 4:


                        Stack<int> pilaNumeros = new Stack<int>();

                        string datospila;

                        Console.WriteLine(" Ingrese numero a la pila... 'fin' para terminar.");

                        while (true)
                        {
                            Console.Write("Ingresa un numero: ");
                            datospila = Console.ReadLine();

                            if (datospila.ToLower() == "fin")
                            {
                                break;
                            }

                            if (int.TryParse(datospila, out int numero))
                            {
                                pilaNumeros.Push(numero);
                            }
                            else
                            {
                                Console.WriteLine("Entrada no válida. Ingrese solo números.");
                            }

                        }

                        OperacionesPila.MenuPila(pilaNumeros);
                        break;

                    default:
                        Console.WriteLine("Elige Correctamente la opcion");
                        seleccion = int.Parse(Console.ReadLine());
                        MenuSecundario(seleccion);


                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se permiten solo Numeros");
                MenuPrincipal();
            }

        }
    }
}
