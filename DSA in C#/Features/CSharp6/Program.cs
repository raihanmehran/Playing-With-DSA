using System.Collections;

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
        Console.WriteLine("Hello");

        int[] arr = new int[5];

        var arr2 = new int[5];

        List<Student> studentList = new List<Student>();
        List<int> numberList = new List<int>();
        List<int> numberList2 = [];

        ArrayList arrayList = new ArrayList();
        System.Console.WriteLine(arrayList.Capacity);

        arrayList.Add(10);
        arrayList.Add(10);
        arrayList.Add(10);
        System.Console.WriteLine(arrayList.Capacity);



        arrayList.Add('a');
        arrayList.Add('b');
        System.Console.WriteLine(arrayList.Capacity);

        printArrayList(arrayList: arrayList);

        arrayList.Insert(2, 30);

        printArrayList(arrayList: arrayList);

        arrayList.Remove('a');

        printArrayList(arrayList);

        arrayList.RemoveAt(3);

        printArrayList(arrayList);


        Console.WriteLine("\n Hello, World!");
    }

    static void printArrayList(ArrayList arrayList)
    {
        System.Console.WriteLine();
        int index = 0;
        foreach (object obj in arrayList)
        {
            System.Console.WriteLine($"{index} : {obj} ");
            index++;
        }
    }
}
