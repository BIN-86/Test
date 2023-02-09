using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{

    void Update()
    {
        if (Key.keyCount >= 3)
        {
            Destroy(this.gameObject);
        }
    }
}
