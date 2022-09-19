using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CollatzTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void CollatzTestSimplePasses()
    {
        int[] input = { 4, 2, 8, 3, 9, 4, 10 };
        int[] output = Collatz.collatzs(input);
        int[] expected = { 2, 1, 4, 10, 28, 2, 5 };

        CollectionAssert.AreEqual(expected, output);

    }

}
