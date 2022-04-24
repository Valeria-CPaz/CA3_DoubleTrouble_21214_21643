using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boyMove : MonoBehaviour
{
    public float speed = 6f;


    // Update is called once per frame
    void FixedUpdate()
    {
        //Movement controls
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(h, v) * speed;
        //link movement to animator
        GetComponent<Animator>().SetInteger("X", (int)h);
        GetComponent<Animator>().SetInteger("Y", (int)v);
    }
}
