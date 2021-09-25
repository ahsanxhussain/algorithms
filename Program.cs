/*
 * Creating LinkedList and inserting nodes: Data Structures 
 * Author: M Ahsan Hussain
 * Github: @ahsanxhussain
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("LINKED LIST");
            
            SinglyLinkedList myList = new SinglyLinkedList();
            
            //taking inputs for nodes
            Console.WriteLine("Enter first value: ");
            int node1 =  Convert.ToInt32(Console.ReadLine());
            myList.insertFirst(node1);
            Console.WriteLine("Enter second value: ");
            int node2 =  Convert.ToInt32(Console.ReadLine());
            myList.insertFirst(node2);
            Console.WriteLine("Enter third value: ");
            int node3 =  Convert.ToInt32(Console.ReadLine());
            myList.insertFirst(node3);
            Console.WriteLine("Enter fourth value: ");
            int node4 =  Convert.ToInt32(Console.ReadLine());
            myList.insertFirst(node4);
            Console.WriteLine("Enter fifth value: ");
            int node5 =  Convert.ToInt32(Console.ReadLine());
            myList.insertFirst(node5);
            Console.WriteLine("Enter last value: ");
            int lastNode =  Convert.ToInt32(Console.ReadLine());
            myList.insertLast(lastNode);

            myList.displayList();

            /* Deleting a node
             * myList.deleteFirst();
             * mylist.displayList();
             */
           
        }  
    }

    /*
     * step 2
     * to check if head node points to empty node
     */
    
    public class SinglyLinkedList{
        private Node first;
        public bool isEmpty(){
            return(first == null);
        }

        /*step3
         * insert a first node
         * call instance from Node class
         * assign first to next
         */
         public void insertFirst(int data){
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = first;
            first = newNode;
         }
         public Node deleteFirst(){
            Node temp = first;
            first = first.next;
            return temp;
         }
        /*step 4
         * display list
         */

        public void displayList(){
            Console.WriteLine("list(first -- last)");
            Node current = first;
            while (current!=null)
	        {
                current.displayNode();
                current = current.next;
	        }
            Console.WriteLine();
        }       
        public void insertLast(int data){
            Node current = first;
            while (current.next != null)
	        {
                current = current.next;
	        }
            Node newNode = new Node();
            newNode.data = data;
            current.next = newNode;
        }
    }

    /* step 1
     * basic structure
     * of a Node
     */
    public class Node {

        public int data;
        public Node next;  
        public void displayNode(){
            Console.WriteLine(data);
        }
            
    }


}

/*
 * Disclaimer:
 * This code is for education purpose only and can be modified by individuals as per 
 * their need. 
 * Credits
 * Reynald Adolphe 
 */
