using System;

namespace LinkedLists
{
    public class Node 
    {
        public int data;
        public Node next;

        public Node(int i)
        {
            data = i;
            next = null; // El primer Nodo creado no tiene ningún Nodo siguiente
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
            else if (data < next.data) 
            {
                Node temp = new Node(data);
                temp.next = this.next;
                this.next = temp;
            }
            else 
            {
                next.AddSorted(data);
            }
        }
        public void AddToEnd(int data) 
        {
            if (this.next == null) // Quiere decir que estamos al final de la lista
            {
                this.next = new Node(data); // Crea un nuevo Nodo siguiente 
            }
            else 
            {
                this.next.AddToEnd(data); // Pasa responsabilidad de la lógica al siguiente Nodo
            }
        }
    }
    public class MyList
    {
        public Node headNode;

        public MyList()
        {
            headNode = null;
        }

        public void AddToEnd(int data) 
        {
            if (headNode == null) // Quiere decir que es el primer Nodo
            {
                headNode = new Node(data);
            }
            else 
            {
                headNode.AddToEnd(data);
            }
        }
        public void AddSorted(int data) 
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else if (data < headNode.data)
            {
                AddToBeginning(data);
            }
            else 
            {
                headNode.AddSorted(data);
            }
        }
        public void AddToBeginning(int data)
        {
            if (headNode == null) // Quiere decir que es el primer nodo 
            {
                headNode = new Node(data);
            }
            else 
            {
                Node temp = new Node(data); // Creamos un nodo temporal y cambiamos los pointers
                temp.next = headNode; 
                headNode = temp;
            }
        }
        public void Sort() 
        {
            // Cómo ordenar de menor a mayor la lista de Nodos
            
        }
        public void Print() 
        {
            if (headNode != null) // Quiere decir que es un nodo entre el primero y el último
            {
                headNode.Print();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyList List = new MyList();
            List.AddToEnd(8);
            List.AddToEnd(5);
            List.AddToEnd(7);
            List.AddToBeginning(32);
            List.AddSorted(43);
            List.AddSorted(2);
            List.Print();
        }
    }
}
