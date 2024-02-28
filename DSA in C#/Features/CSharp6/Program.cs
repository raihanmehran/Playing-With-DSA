using System.Collections;
using CSharp6;

namespace Features;

class Student
{
    public int Id { get; set; }
    public String Name { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[5];

        var arr2 = new int[5];

        List<Student> studentList = new List<Student>();
        List<int> numberList = new List<int>();
        List<int> numberList2 = [];

        // Non-Generic Collections: Stack, Queue, LinkedList, SortedList, ArrayList, Hashtable

        /*
            Array vs ArrayList (+ Non-Generic collection) vs Generic Collections
            Array: Type safe but fixed length.
            ArrayList: Dynamic or changeable length but no type safety.
            Generic Collection: Provides both dynamic length and type safety        
        */

        // WorkingWithArrayList();
        // WorkingWithHashtable();
        // WorkingWithGenericList();

        WorkingWithGenerics();
    }

    static void PrintArrayList(ArrayList arrayList)
    {
        System.Console.WriteLine();
        int index = 0;
        foreach (object obj in arrayList)
        {
            System.Console.WriteLine($"{index} : {obj} ");
            index++;
        }
    }

    static void WorkingWithArrayList()
    {
        ArrayList arrayList = new ArrayList();
        System.Console.WriteLine(arrayList.Capacity);

        arrayList.Add(10);
        arrayList.Add(10);
        arrayList.Add(10);
        System.Console.WriteLine(arrayList.Capacity);

        arrayList.Add('a');
        arrayList.Add('b');
        System.Console.WriteLine(arrayList.Capacity);

        PrintArrayList(arrayList: arrayList);

        arrayList.Insert(2, 30);

        PrintArrayList(arrayList: arrayList);

        arrayList.Remove('a');

        PrintArrayList(arrayList);

        arrayList.RemoveAt(3);

        PrintArrayList(arrayList);

    }
    static void WorkingWithHashtable()
    {
        // Hashtable: Key/Value Combination
        Hashtable htEmployee = new Hashtable();
        //Hashtable htEmployee = [];

        htEmployee.Add("Eid", 1010);
        htEmployee.Add("Ename", "Scott");
        htEmployee.Add("Job", "Manager");
        htEmployee.Add("Salary", 25000.00);

        System.Console.WriteLine(htEmployee["Job"]);

        foreach (var key in htEmployee.Keys) System.Console.WriteLine($"{key} : {htEmployee[key]}");

        // every hashtable stores key,value, and hashcode for every record. hashcode is used for faster data retrieval from hashtable.
        var hashCode = "Salary".GetHashCode();
        System.Console.WriteLine(hashCode);
        System.Console.WriteLine(htEmployee[hashCode]); // this doesn't work better to figure out why?
    }

    static void WorkingWithGenericList()
    {
        List<int> li = new List<int>();
        li.Add(10);
        li.Add(20);
        li.Add(30);
        li.Add(40);
        // li.Add(5.0); // Cannot insert float/double value
        li.Add(60);
        li.Add(70);
        li.Add(80);
        li.Add(90);

        foreach (var i in li) System.Console.Write($"\t {i}");
        System.Console.WriteLine();

        // Inserting item in the middle
        li.Insert(4, 50);
        foreach (var i in li) System.Console.Write($"\t {i}");
        System.Console.WriteLine();

        // removing item from the middle or specific index:
        li.RemoveAt(4);
        foreach (var i in li) System.Console.Write($"\t {i}");
        System.Console.WriteLine();
    }

    static void WorkingWithGenerics()
    {
        // Generics1 generics1 = new Generics1();
        // generics1.Add<int>(a: 10, b: 20);
        // generics1.Sub<float>(a: 20, b: 12.5f);

        // We can also make the class generic, so then we don't need to mention the type in every function
        Generics1<int> generics1 = new Generics1<int>();
        generics1.Add(a: 10, b: 20);
        generics1.Sub(a: 20, b: 12);
    }
}
