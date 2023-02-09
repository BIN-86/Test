using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryMonster : MonoBehaviour
{
    public GameObject Attack;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == Attack.name)
        {
            Destroy(this.gameObject);
        }
    }
}
