﻿class Program
{
    public static void Main(String[] args)
    {
        //Test in case return null
        Console.WriteLine("{0}",Min(null));

        //Add data to list
        List<int> list = new List<int>();
        list.Add(10);
        list.Add(1);
        list.Add(1230);
        //Test in case does not return null
        Console.WriteLine("{0}",GetFirst(list));
    }

    private static int? GetFirst(List<int> list)
}