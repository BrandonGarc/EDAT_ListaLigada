namespace ListaLigada.Logica
{
    public class SingleNode <T> 
    {
        public T? Data { get; set; }

        public SingleNode <T>? Next { get; set; } // Guarda direcciones de memoria 

        public SingleNode (T data)
        {
            Data = data;
            Next = null;

        }
        }
}

//Apuntes de Clase 
//Para hacer las operaciones se necesitan punteros
