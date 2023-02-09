using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public static int value;

    public int startCount = 0;
    void Start()
    {
        value = startCount;
    }
}
