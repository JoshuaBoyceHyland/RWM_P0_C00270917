using Codice.Client.BaseCommands;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Mod3Filter
{

    // Update is called once per frame
    public int[] mod3( int[] uncubedArray )
    {
        int[] cubedArray = new int[uncubedArray.Length];

        for (int i = 0; i < uncubedArray.Length; i++)
        {
            cubedArray[i] = uncubedArray[i] % 3;
        }

        return cubedArray;
    }
}
