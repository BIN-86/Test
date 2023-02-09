using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public float speed = 1;

    public GameObject Player;
    Rigidbody2D rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.gravityScale = 0;
        rigid.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void Update()
    {
        Vector3 dir = (Player.transform.position - this.transform.position).normalized;

        float VX = dir.x * speed;
        float vy = dir.y * speed;

        rigid.velocity = new Vector2(VX, vy);

        this.GetComponent<SpriteRenderer>().flipX = (VX < 0);
    }
}
