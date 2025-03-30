using System;
using System.Reflection;

class DriverTwo
{
    public static void Main()
    {
        // String List
        List<String> list = new List<String>();
        list.Add("Cromwell");
        list.Add("Emerald");
        list.Add("Dave");
        list.Add("Duo");
        list.Add("Stewie");
        list.Add("Peter");

        // Integer List
        List<int> list_age = new List<int>();
        list_age.Add(22);
        list_age.Add(21);
        list_age.Add(18);
        list_age.Add(13);
        list_age.Add(7);
        list_age.Add(46);

        // Doubly List
        DoubleList<String> list_double = new DoubleList<String>();
        list_double.Add("Cromwell");
        list_double.Add("Dave");
        list_double.Add("Emerald");
        list_double.Add("Josh");
        list_double.Add("Emma");


        Console.WriteLine("Searching for Node...");

        // The returned node
        Node<String> node = list.Get("Peter");

        Console.WriteLine("Returned the following node: " + node.GetData().ToString());
        

    }
}