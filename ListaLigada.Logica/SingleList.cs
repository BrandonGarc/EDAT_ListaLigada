namespace ListaLigada.Logica
{
    public class SingleList <T>
    {
        private SingleNode<T>? _first;

        public SingleList()

        {
            _first = null;
        }

        public bool isEmpy => _first == null; // Se compara para ver si la lista esta vacía

        public void Add(T item) 
        {

            var node = new SingleNode<T>(item);

            //La fución de _First y pointer es apuntar a los nodos y recorrer la lista

            if (isEmpy) //Si la lista esta vacia
            {
                _first = node; //_First es un puntero
            }
            else
            {
                var pointer = _first;

                while (pointer!.Next != null)
                {
                    pointer = pointer.Next;
                }

                pointer!.Next = node;



            }
            
            



        }

        /*public bool Remove (T elemento)
        {
            var pointer = _first;

        }
        */

        public override string ToString()
        {
            var cadenaLista = string.Empty;
            var pointer = _first;

            while (pointer!= null)
            {
                cadenaLista += $"{pointer.Data}\n";
                pointer = pointer.Next;
            }
            

            return cadenaLista;

        }




    }
}
