using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour
{
    float x = 0;
    int lv = 1;
    bool 草地bool = false;
    Rigidbody2D rBody;
    public Animator Big;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        Big = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        //Vector2 vector=Vector2.zero;
        //vector.x = Input.GetAxis("Horizontal") * Time.deltaTime * 10;
        //rBody.velocityX += Input.GetAxis("Horizontal") * Time.deltaTime * 10;
        x += Input.GetAxis("Horizontal") * Time.deltaTime * 5;
rBody.velocityX = x;


        if (Input.GetAxisRaw("Horizontal") == 1)
        {

            Big.enabled = true;
        }
        else
        {
            Big.enabled = false;
        }
        if (草地bool && Input.GetAxisRaw("Jump") == 1)
        {
            草地bool = false;
            rBody.velocityY = 6;
        }
        


        //transform.position = vector;
    }




    private void OnCollisionStay2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "草地")
        {
            草地bool = true;
        }
    }
}
