using System;

internal class _005
{
    static void Main1(string[] args)
    {
        string A = Console.ReadLine();
        int[] all = new int[int.Parse(A)];
        for (int i = 0; i < int.Parse(A); i++)
        {
            all[i] = i + 1;
            Console.WriteLine(all[i]);
        }
    }
}