using System;
using System.Reflection;

class DriverTwo
{
    public static void Main()
    {
        // String Hash Map
        List<String> list = new List<String>();
        list.Add("Cromwell");
        list.Add("Emerald");
        list.Add("Dave");
        list.Add("Duo");
        list.Add("Stewie");
        list.Add("Peter");

        List<int> list_age = new List<int>();
        list_age.Add(22);
        list_age.Add(21);
        list_age.Add(18);
        list_age.Add(13);
        list_age.Add(7);
        list_age.Add(46);

        // Print the string hash map
        list.Print();
        Console.WriteLine();


        // Print the age hash map
        list_age.Print();
        

    }
}