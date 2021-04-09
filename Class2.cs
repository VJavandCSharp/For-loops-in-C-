using System;

public class Class1
{
    static void Main(string[] args)
    {
        string[] people = { "John Doe", "Jane Doe" };
        for (int i = 0; i < people.Length; i++)
        {
            Console.WriteLine(people[i]); // Prints John Doe, Jane Doe <-- Last index ([1]).
        }
    }
}
