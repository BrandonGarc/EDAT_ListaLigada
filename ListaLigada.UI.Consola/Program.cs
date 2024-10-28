
using ListaLigada.Logica;
using System.ComponentModel.Design;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lista Ligada simple");


        var singleList = new SingleList<string>();

        int opcion = 0;
        do
        {
            opcion = Menu();

            switch (opcion)
            {
                case 1: AgregarElemento(); break;
                case 2: MostrarLista(); break;
               // case 3: EliminarElemnto(); break;
                case 0: break;
                default: Console.WriteLine("Esta opción no existe"); break;
            }
        }


        
        while (opcion != 0);

            void AgregarElemento()
        {
            Console.WriteLine("Escribe el nombre del nodo");
            var data = Console.ReadLine();
            singleList.Add(data);
        }


        void MostrarLista()
        {
            Console.WriteLine("La lista es: ");
            Console.WriteLine(singleList);
        }
        void EliminarElemento()
        {

        }
        Console.ReadKey();

        //Termina el main 
    }

    

    private static int Menu()
    {
        Console.WriteLine("\n Menu \n");
        Console.WriteLine("1. Agregar elemento\n");
        Console.WriteLine("2. Mostrar lista\n");
        Console.WriteLine("3. Eliminar elemento\n");
        Console.WriteLine("0. Salir\n");

        bool esValido = false;
        int opcion = 0;

        do
        {
            Console.WriteLine("Elige una opción del menú");
            var opcionCapturada = Console.ReadLine();

            if (int.TryParse(opcionCapturada, out opcion) || opcion<0 || opcion>2 )  
            {
                Console.WriteLine("Digite una opción valida");

                esValido = false;
            }
            else
            {
                esValido = true;
            }
        }

        while (esValido==false);
      
        return opcion;


    }
}