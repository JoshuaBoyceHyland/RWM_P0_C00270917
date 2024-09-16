using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Testscript
{
    // A Test behaves as an ordinary method
    [Test]
    public void Mod3FilterSimple()
    {
        Mod3Filter mod3Filter = new Mod3Filter();
        int[] input = { 7, 2, 8, 3, 9, 4, 10, 5, 11, 6 };
        int[] output = mod3Filter.mod3(input);
        int[] expected = { 1, 2, 2, 0, 0, 1, 1, 2, 2, 0 };
        CollectionAssert.AreEqual(expected, output);

    }
}
