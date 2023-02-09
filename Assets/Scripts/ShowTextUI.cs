using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ShowTextUI : MonoBehaviour
{
    //Text tetCounter;

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMP_Text>().text = Key.keyCount.ToString();
    }
}
