using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuEstudiantil
{
    internal class OperacionesPila
    {
        public static void MenuPila(Stack<int> pila)
        {
            try
            {

                Console.WriteLine(" --- Matrices ---");
                Console.WriteLine(" 1) Mostrar pila");
                Console.WriteLine(" 2) Añadir numeros a la pila");
                Console.WriteLine(" 3) Borrar numeros de la pila");
                Console.WriteLine(" 4) Obtener el elemento superior de la pila sin eliminarlo");
                Console.WriteLine(" 5) Obtener la cantidad de elementos en la pila");
                Console.WriteLine(" 6) Volver a Ingresar numeros a la pila");
                Console.WriteLine(" 7) Regresar Menu principal");
                Console.WriteLine("Elige una de las opciones");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        MostrarPila(pila);
                        break;
                    case 2:
                        AgregarPila(pila);
                        break;
                    case 3:
                        EliminarPila(pila);
                        break;
                    case 4:
                        elementoSuperior(pila);
                        break;
                    case 5:
                        cantidadElementos(pila);
                        break;

                    case 6:
                        Console.Clear();
                        Menu.MenuSecundario(4);
                        break;
                    case 7:
                        Console.Clear();
                        Menu.MenuPrincipal();
                        break;

                    default:
                        Console.WriteLine("Elige Correctamente la opcion");
                        MenuPila(pila);
                        break;

                }





            }
            catch (Exception ex)
            {
                Console.WriteLine("Se permiten solo Numeros");
                MenuPila(pila);
            }

        }
        static void MostrarPila(Stack<int> pila)
        {



            foreach (int pilas in pila)
            {
                Console.WriteLine(pilas);
            }

            MenuPila(pila);
            Console.ReadLine();
        }
        static void AgregarPila(Stack<int> pila)
        {

            Console.Write("Adiccionar un numero a la pila: ");
            int numero = int.Parse(Console.ReadLine());

            // Añadir elementos a la pila
            pila.Push(numero);

            MenuPila(pila);
            Console.ReadLine();
        }
        static void EliminarPila(Stack<int> pila)
        {
         
            // eliminar elemento de la pila
            pila.Pop();

            MenuPila(pila);
            Console.ReadLine();
        }
        static void elementoSuperior(Stack<int> pila)
        {

            pila.Peek();

            MenuPila(pila);
            Console.ReadLine();
        }
        static void cantidadElementos(Stack<int> pila)
        {

            pila.Count();


            MenuPila(pila);
            Console.ReadLine();
        }
    }
   

}
