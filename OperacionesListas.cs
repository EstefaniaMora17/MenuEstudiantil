using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuEstudiantil
{
    internal class OperacionesListas
    {
        public static void MenuListas(List<int> lista)
        {
            try
            {

                Console.WriteLine(" --- Matrices ---");
                Console.WriteLine(" 1) Mostrar Lista");
                Console.WriteLine(" 2) Añadir numeros a la lista");
                Console.WriteLine(" 3) Borrar numeros de la lista");
                Console.WriteLine(" 4) Ordenar los numeros de la lista");
                Console.WriteLine(" 5) Ordenar numeros de la lista descendente");
                Console.WriteLine(" 6) Volver a Ingresar numeros a la lista");
                Console.WriteLine(" 7) Regresar Menu principal");
                Console.WriteLine("Elige una de las opciones");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        MostrarLista(lista);
                        break;
                    case 2:
                        AgregarLista(lista);
                        break;
                    case 3:
                        ElimarElemento(lista);
                        break;
                    case 4:
                        OrdenarLista(lista);
                        break;
                    case 5:
                        OrdenarListaDescendente(lista);
                        break;

                    case 6:
                        Console.Clear();
                        Menu.MenuSecundario(3);
                        break;
                    case 7:
                        Console.Clear();
                        Menu.MenuPrincipal();
                        break;

                    default:
                        Console.WriteLine("Elige Correctamente la opcion");
                        MenuListas(lista);
                        break;

                }





            }
            catch (Exception ex)
            {
                Console.WriteLine("Se permiten solo Numeros");
                MenuListas(lista);
            }

        }
        static void MostrarLista(List<int> lista)
        {



            foreach (int listas in lista)
            {
                Console.WriteLine(listas);
            }

            MenuListas(lista);
            Console.ReadLine();
        }
        static void AgregarLista(List<int> lista)
        {

            Console.Write("Adicciona un dato a la lista: ");
            int dato = int.Parse(Console.ReadLine());

            // Añadir elementos a la lista
            lista.Add(dato);

            MenuListas(lista);
            Console.ReadLine();
        }
        static void ElimarElemento(List<int> lista)
        {

            Console.Write("Ingresa el numero del dato que quiere eliminar ");
            int dato = int.Parse(Console.ReadLine());

            // eliminar elementos a la lista
            lista.Remove(dato);

            MenuListas(lista);
            Console.ReadLine();
        }
        static void OrdenarLista( List<int> lista)
        {

            
          
            lista.Sort(); 


            MenuListas(lista);
            Console.ReadLine();
        }
        static void OrdenarListaDescendente(List<int> lista)
        {



            lista.Reverse();


            MenuListas(lista);
            Console.ReadLine();
        }
    }
   

}
