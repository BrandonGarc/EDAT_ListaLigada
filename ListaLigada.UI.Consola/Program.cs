
using ListaLigada.Logica;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lista Ligada simple");


        var singleList = new SingleList<string>();

        singleList.Add("Alondra");
        singleList.Add("Karla");
        singleList.Add("Juan");
        singleList.Add("Luis");
        singleList.Add("José");

        Console.WriteLine(singleList);


        Console.ReadKey();
    }
}