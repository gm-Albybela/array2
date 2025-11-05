using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine();
        int[] N = { 7, 6, 8, 5, 9 };
        for (int i = 0; i < N.Length; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(N[i]);
            }
        }



    }
}

