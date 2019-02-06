using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace Csharp.Day3.Example4
{
    class ProgramCollection
    {

        static void Main1(string[] args)
        {

            // Collection can be resized like arrays

            // ------------ ArrayLists -----------

            #region ArrayList
            ArrayList list = new ArrayList();

            // add elements 
            list.Add("baddi");
            list.Add(50);
            list.Add(51);
            list.Add("baddi");
            list.Add(50);

            // number of element in the array list
            Console.WriteLine("Count : {0}", list.Count);

            // capacity of element in the array list
            Console.WriteLine("Capacity : {0}", list.Capacity);

            ArrayList list2 = new ArrayList();
            // add an array
            list2.AddRange(new Object[] { "baddi", "Youssef", "Aymen" });

            // add an Arraylist
            list.AddRange(list2);

            // sort and reverse
            list2.Sort();

            foreach(object o in list2)
            {
                Console.WriteLine(o);
            }

            // sort and reverse
            list2.Reverse();

            foreach (object o in list2)
            {
                Console.WriteLine(o);
            }

            ArrayList list3 = list.GetRange(0,3);
            foreach (object o in list3)
            {
                Console.WriteLine(o);
            }

            foreach (object o in list)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("###########################");

            list.Insert(1, "hello");
            foreach (object o in list)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("###########################");
            list.Remove(50);

            foreach (object o in list)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("###########################");
            list.RemoveAt(2);

            foreach (object o in list)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine("###########################");
            list.RemoveRange(1,2);

            foreach (object o in list)
            {
                Console.WriteLine(o);
            }

            // to search 
            Console.WriteLine("baddi is in index : {0}",
                list.IndexOf("baddi",0));

            // join to convert arraylist to string
            String[] myarrayOfString = (string[])list2.ToArray(typeof(string));
            foreach (string o in myarrayOfString)
            {
                Console.WriteLine(o);
            }

            // convert table of string to arraylist
            string[] objects = { "baddi", "Youssef", "Aymen" };
            ArrayList list4 = new ArrayList();
            list4.AddRange(objects);

            foreach (Object o in list4)
            {
                Console.WriteLine(o);
            }

            #endregion

            #region Dict
            // Dictionnaires

            Dictionary<string,string> students = new Dictionary<string, string>();

            students.Add("e1", "etudiant1");
            students.Add("e2", "etudiant2");
            //students.Add("e2", "etudiant2");
            students.Add("e3", "etudiant3");
            students.Add("e4", null);

            // display items
            DisplayDict(students);

            students.Remove("e2");
            // display items
            DisplayDict(students);

            

            // check if key exist 
            Console.WriteLine("contains : {0}",
                students.ContainsKey("e4"));

            // check if key exist 
            Console.WriteLine("e4 value is  : {0}",
                students["e3"]);

            // get the value for the key and store it in a string
            students.TryGetValue("e3", out string valueStr);
            Console.WriteLine("out string : {0}",
                valueStr);

            // Count
            Console.WriteLine("Count : {0}",
                students.Count);


            students.Clear();
            // display items
            DisplayDict(students);

            #endregion

            #region sortedDict
            // Create a new sorted dictionary of strings, with string
            // keys.
            SortedDictionary<string, string> openWith =
                new SortedDictionary<string, string>();

            // Add some elements to the dictionary. There are no 
            // duplicate keys, but some of the values are duplicates.
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            Console.WriteLine();
            foreach (KeyValuePair<string, string> kvp in openWith)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }
            #endregion

            #region Queue
            Queue q = new Queue();

            // enqueue
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);

            // test if exist
            Console.WriteLine("contains {0}", q.Contains(1));

            // peek element that will be removed
            Console.WriteLine("Peek 1: {0}", q.Peek());

            // peek element that will be removed
            Console.WriteLine("Peek 1: {0}", q.Dequeue());

            foreach (object o in q)
            {
                Console.WriteLine(o);
            }

            Console.WriteLine(string.Join(",",q.ToArray()));

            q.Clear();
            #endregion

            #region Stack
            Stack a = new Stack();

            // Push

            // Peek

            // Pop


            #endregion
            // 



            Console.ReadLine();
        }

        private static void DisplayDict(Dictionary<string, string> students)
        {
            foreach(KeyValuePair<string,string> item in students)
            {
                Console.WriteLine($"key {item.Key} : value {item.Value}");
            }
        }
    }
}
