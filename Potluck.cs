using System;

class Potluck
{
    static void Main()
    {
        string[] guestList = { "Michael", "Gaby", "Mark", "Brian"};

        foreach (string name in guestList)
        {
            if (String.Compare(name.Substring(0, 1), "M") < 0)
            {
                Console.WriteLine(name + " should bring a main dish.");
            }
            else
            {
                Console.WriteLine(name + " should bring a side dish.");
            }
        }
    }
}