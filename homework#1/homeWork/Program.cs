// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] array = { 98, 21, 22, 23, 431, 11  , 67};

        Console.WriteLine(min(array));

    
    
    }
    static int min(int[] array)
    {
        int enKicikEded = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (enKicikEded > array[i])
            {
                enKicikEded = array[i];
            }
             
        }
        return enKicikEded;
    }
}
