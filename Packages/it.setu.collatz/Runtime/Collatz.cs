using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collatz
{
    public static int collatz(int x)
    {
        //If odd
        if (x % 2 != 0)
        {
            return (3*x) + 1;
        }
        //If even
        else
        {
            return x / 2;
        }
    }

    public static int[] collatzs(int[] xs)
    {
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = collatz(xs[i]);
        }
        return result;
    }

}
