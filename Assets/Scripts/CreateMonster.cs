using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMonster : MonoBehaviour
{
    public GameObject monster;
    public float Sec = 1;
    void Start()
    {
        InvokeRepeating("CreateM", Sec, Sec);
    }

    // Update is called once per frame
    void CreateM()
    {
        Vector3 bPos = GetComponent<SpriteRenderer>().bounds.size;

        Vector3 mPos = this.transform.position;
        mPos.x += Random.Range(-bPos.x / 2, bPos.x / 2);
        mPos.y += Random.Range(-bPos.y / 2, bPos.y / 2);
        mPos.z = -8;

        GameObject newgameObject = Instantiate(monster) as GameObject;
        newgameObject.transform.position = mPos;
    }
}
