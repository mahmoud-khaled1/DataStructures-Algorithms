using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Table
{
    /*we can see the implementation of Node, which has key, value
     * as well pointers for chaining, Next and Previous. 
     * "universe" is an array of Node in our code so we can 
     * chain out any collision.
     */
    public class Node
    {
        public string Key { get; set; }
        public object Value { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }
    }

    /*
     *  In this section, we will implement our own hash table 
     *  using own hash function and our own methods to manipulate the table.
     *  We will use chaining (Linked List) to deal with collisions, 
     *  where we could analyze how actually does a hash table work 
     *  as well hash function.
     */

    public class MyHashTable
    {
        private Node[] universe;
        private readonly int tableSize;

        public MyHashTable(int maxTableSize)
        {
            tableSize = maxTableSize;
            universe = new Node[tableSize];
        }

        /*
         We have to be very careful while writing hash functions because
        a good hash function can decrease the chances of collision
        and distribute data uniformly, There are set of rules to choose 
        hash function and some algorithms as well, Here we used division 
        method which divides and gives reminder, here we can see 
        we used 7(a prime) to start with and 31(again prime), 
        primes are good make random hash, as well I multiplied ASCII value
        with character position in string so "aSp" and "AsP" won't be 
        same as well "asp" and "psa". If possible make table size also prime.
          
         */
        private int HashFuncation(string key)
        {
            int index = 7;
            int asciiVal = 0;
            for (int i = 0; i < key.Length; i++)
            {
                asciiVal = (int)key[i] * i;
                index = index * 31 + asciiVal;
            }
            return index % tableSize;
        }
        /*
          Insert function first generates the hash index then whether 
        on the index some node is there or it is null, if null then 
        creates a node with value, if already a node then it is collision
        then it uses linked list logic to iterate until  reach to end and 
        at end we chain a new node, meanwhile we check also if some key is
        exactly same, if we find same key then we throw an exception saying 
        can't use same key again.
         */
        public void Insert(string key, object value)
        {
            int genIndex = HashFuncation(key);
            Node node = universe[genIndex];

            if (node == null)
            {
                universe[genIndex] = new Node() { Key = key, Value = value };
                return;
            }

            if (node.Key == key)
                throw new Exception("Can't use same key!");

            while (node.Next != null)
            {
                node = node.Next;
                if (node.Key == key)
                    throw new Exception("Can't use same key!");
            }

            Node newNode = new Node() { Key = key, Value = value, Previous = node, Next = null };
            node.Next = newNode;
        }
        public object GetValue(string key)
        {
            int genIndex = HashFuncation(key);
            Node node = universe[genIndex];
            while (node != null)
            {
                if (node.Key == key)
                {
                    return node.Value;
                }
                node = node.Next;
            }

            throw new Exception("Don't have the key in hash!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyHashTable hashTable = new MyHashTable(50);
            hashTable.Insert("ab", 5);
            hashTable.Insert("bb", 6);
            hashTable.Insert("aB", 7);
            hashTable.Insert("Bc", 8);
            hashTable.Insert("cA", 9);
            hashTable.Insert("CC", 10);

            Console.WriteLine("Value of key 'bb' is: " + hashTable.GetValue("bb"));
            Console.ReadLine();
        }
    }
}
