using System.Collections.Generic;
namespace LinkedLists
{
    public class LinkedList
    {
        public Node headNode;
        public LinkedList() // Constructor
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
        public void Append(int data)
        {
            Node currentNode = headNode;
            if (headNode == null) 
            {
                headNode = new Node(data);
                return;
            }
            while (currentNode.next != null)    {
                currentNode = currentNode.next;
            }
            currentNode.next = new Node(data);

        }
        public void Insert(int data, int position) 
        {
            if (position <= 1) 
            {
                throw new System.ArgumentOutOfRangeException("La posición no puede ser el inicio de la lista.");
                
            }
           
            Node newNode = new Node(data);
            Node current = headNode;

            if (headNode == null ) {  return; } 
            int count = 0; 

            for (var i = 1; i < position - 1; i++)
            {
                count++;
                if (current.next != null) 
                {
                    current = current.next;
                }
                else 
                {
                    throw new System.ArgumentOutOfRangeException("La posición excede el máximo de la lista.");
                }
            }
            newNode.next = current.next;
            current.next = newNode;
        }
        public void Print()
        {
            if (headNode != null) // Quiere decir que es un nodo entre el primero y el último
            {
                headNode.Print();
            }
        }
        public LinkedList Sort() 
        {
            Node currentNode = headNode;
            
            var referenceList = new List<int>();

            if (headNode == null || headNode.next == null) 
            {
                return null;
            }
            
            while (currentNode.next != null)
            {
                var currentData = currentNode.data;
                referenceList.Add(currentData);
                currentNode = currentNode.next;

            }
            
            referenceList.Sort();
            var sortedList = new LinkedList();

            foreach (var data in referenceList)
            {
                sortedList.Append(data);
            }
            System.Console.WriteLine();

            return sortedList;
            

            // Cómo ordenar de menor a mayor la lista de Nodos?
        }
    }
}