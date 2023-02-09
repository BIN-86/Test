using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl : MonoBehaviour
{
    public string UpAnime = "Back";
    public string DownAnime = "Front";
    public string RightAnime = "Right";
    public string LeftAnime = "Left";

    string nowAnim = "";

    public GameObject frefabFlower;

    Rigidbody2D rigid;

    public float speed = 3;
    float vx = 0;
    float vy = 0;

   
    void Start()
    {
        nowAnim = DownAnime;
        rigid = GetComponent<Rigidbody2D>();
        rigid.gravityScale = 0;
        rigid.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        vx = 0;
        vy = 0;

        if (Input.GetKey("up"))
        {
            nowAnim = UpAnime;
        }
        if (Input.GetKey("down"))
        {
            nowAnim = DownAnime;
        }
        if (Input.GetKey("right"))
        {
            nowAnim = RightAnime;
            vx = speed;
        }
        if (Input.GetKey("left"))
        {
            nowAnim = LeftAnime;
            vx = -speed;
        }
        

    }
    private void FixedUpdate()
    {
        this.GetComponent<Animator>().Play(nowAnim);

        this.transform.Translate(vx / 50, vy / 50, 0);
       
        /*
        GameObject _newGameObject = Instantiate(frefabFlower) as GameObject;

        float ixRand = Random.Range(-10f, 10f);
        //float iyRand = Random.Range(-10f, 10f);

        //_newGameObject.transform.position = new Vector3(ixRand, iyRand, 0);
        _newGameObject.transform.Translate(new Vector3(ixRand, 6, 0));
        */
    }
   
}

