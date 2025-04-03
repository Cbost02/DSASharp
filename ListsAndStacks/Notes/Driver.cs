using System;
using System.Reflection;
using Microsoft.AspNetCore.Identity;

class DriverTwo<T>
{
    public static void Main()
    {
        // Declaring some things here
        string? user_input = "";
        List<string> list_string = new List<string>();
        List<int> list_int = new List<int>();
        DoubleList<string>? list_double = new DoubleList<string>();


        // Initializing the lists
        InitializeLists(ref list_string, ref list_int, ref list_double);

        // Retrieving user information
        Console.Write("Enter node key: ");
        user_input = Console.ReadLine();

        Console.WriteLine("Searching for data...");

        if(list_string.hasNode(user_input))
        {
            Console.WriteLine("Found data from list_string: " + list_string.Get(user_input).ToString());
        }
        else if(user_input is int && list_int.hasNode(int.Parse(user_input)))
        {
            Console.WriteLine("Found data from list_int: " + list_int.Get(int.Parse(user_input)).ToString());
        }
        else if(list_double.hasNode(user_input))
        {
            Console.WriteLine("Found data from list_double: " + list_double.Get(user_input).ToString());
        }
        else
        {
            Console.WriteLine("No data found.");
        }

        

    }

    public static void InitializeLists(ref List<string> list1, ref List<int> list2, ref DoubleList<string> list3)
    {

        // Initializing the String list
        list1.Add("Cromwell");
        list1.Add("Emerald");
        list1.Add("Dave");
        list1.Add("Duo");
        list1.Add("Stewie");
        list1.Add("Peter");

        // Initializing the Integer list
        list2.Add(22);
        list2.Add(21);
        list2.Add(18);
        list2.Add(13);
        list2.Add(7);
        list2.Add(46);


        // Initializing the Doubly List
        list3.Add("Cromwell");
        list3.Add("Dave");
        list3.Add("Emerald");
        list3.Add("Josh");
        list3.Add("Emma");

    }
}