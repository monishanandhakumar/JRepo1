using System;
using System.Collections.Generic;
using System.Text;

namespace PrjThirdApplication
{

    class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }

  internal Person(int id,string name,string city)
        {
            this.id = id;
            this.name = name;
            this.city = city;
        }
    }
    class GenericsEg
    {
        static void ListEg()
        {        //typesafe
            List<string> fruits = new List<string>();
            fruits.Add("Mango");
            fruits.Add("Apple");
            fruits.Add("Orange");

            fruits.Insert(1,"Pineapple");
            fruits.RemoveAt(3);
            //  fruits.Add(10); //Typesafe

            List<string> Vegetables = new List<string>();

            Vegetables.Add("Carrot");
            Vegetables.Add("Beetroot");
            Vegetables.AddRange(fruits); //adding onelist into anotherlist
           

            foreach(var list in fruits)
            {
                Console.WriteLine("Fruits:{0}",list);
            }

            Console.WriteLine("Vegetables");

            foreach (var list in Vegetables)
            {
                Console.WriteLine("Vegetables:{0}", list);
            }
        }

        //Key value pair
        static void DictionaryEg()
        {
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1, "Java");
            dt.Add(2,"Networks");
            dt.Add(3, "AI");

            foreach(KeyValuePair<int, string> kp in dt)
            {
                Console.WriteLine(kp.Key+" "+kp.Value);
            }
        }

        static void StackEg()
        {//Push,pop,peek,contains,clear methods

            Stack<int> st = new Stack<int>();
            st.Push(40);
            st.Push(30);
            st.Push(10);
            st.Push(50);

            foreach(var stack in st)
            {
                Console.WriteLine(stack);  //output:50,10,30,40
            }

            st.Pop();

            Console.WriteLine("After 1 pop");

            foreach (var stack in st)
            {
                Console.WriteLine(stack);
            }

            Console.WriteLine("Peek:{0}",st.Peek());

        }

        //SortedList ,Queue
        static void Main()
        {
            ListEg();
            Console.WriteLine("Person details");
            Console.WriteLine("---------------");
            List<Person> person = new List<Person>();
            person.Add(new Person(1,"SAI","Pune"));
            person.Add(new Person(2, "Ram", "Mumbai"));
            person.Add(new Person(3, "Geetha", "Pune"));

            foreach(Person p in person)
            {
                Console.WriteLine("ID:{0} || name:{1} ||City:{2}",p.id,p.name,p.city);
            }
            Console.WriteLine("------------------");
            DictionaryEg();
            Console.WriteLine("------------------");
            StackEg();

        }

    }
}
