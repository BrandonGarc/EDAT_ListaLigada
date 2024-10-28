namespace ListaLigada.Logica
{
    public class SingleList <T>
    {
        private SingleNode<T>? _First;

        public SingleList()

        {
            _First = null;
        }

        public bool isEmpy => _First == null; // Se compara para ver si la lista esta vacía

        public void Add(T item) {

            var node = new SingleNode<T>(item);

            //La fución de _First y pointer es apuntar a los nodos y recorrer la lista

            if (isEmpy) //Si la lista esta vacia
            {
                _First = node; //_First es un puntero
            }
            else
            {
                var pointer = _First;

                while (pointer!.Next != null)
                {
                    pointer = pointer.Next;
                }

                pointer!.Next = node;



            }
            
            



        }

        public override string ToString()
        {
            var cadenaLista = string.Empty;
            var pointer = _First;

            while (pointer!= null)
            {
                cadenaLista += $"{pointer.Data}\n";
                pointer = pointer.Next;
            }
            

            return cadenaLista;

        }




    }
}
