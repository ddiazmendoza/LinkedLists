using System;

namespace LinkedLists
{
    public class Node
    {
        public int data;
        public Node next;
        public int index;

        public Node(int i)
        {
            data = i;
            next = null; // El primer Nodo creado no tiene ningún Nodo siguiente
            index++;
        }
        public void Print()
        {
            Console.Write("|" + data + "|->");
            if (next != null) // Quiere decir que hay un nodo siguiente
            {
                next.Print();   // Por lo tanto, imprimir este nodo siguiente también. || Es recursivo puesto que llamamos el Print() desde el mismo método. 
            }
        }
        public void AddSorted(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else if (data < next.data) // Comparando los números de menor a mayor
            {
                Node temp = new Node(data); // Creando el nuevo Nodo 
                temp.next = next;
                next = temp;
            }
            else
            {
                next.AddSorted(data);
            }
        }
        public void AddToEnd(int data)
        {
            if (next == null) // Quiere decir que estamos al final de la lista
            {
                next = new Node(data); // Crea un nuevo Nodo siguiente 
            }
            else
            {
                next.AddToEnd(data); // Pasa responsabilidad de la lógica al siguiente Nodo
            }
        }
        
    }
}