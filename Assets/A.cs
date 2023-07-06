using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class A : MonoBehaviour
{
    float x = 0;
    int lv = 1;
    bool 草地bool = false;
    Rigidbody2D rBody;
    public Animator Big;
    public GameObject 草地_旋轉;
    public GameObject 草地;
    // Start is called before the first frame update
    void Start()
    {

        rBody = GetComponent<Rigidbody2D>();
        Big = GetComponent<Animator>();

        List<GameObject> gobj = new List<GameObject>();
        for (int n = 10; n < 1080; n += 10)
        {
            GameObject gobj_temp = Instantiate(草地_旋轉);
            //gobj_temp.transform.parent = 草地.transform;
            gobj_temp.transform.localPosition = 草地_旋轉.transform.localPosition + new Vector3(n / 10, 0, 0);

            //gobj_temp.transform.localPosition = Vector3.Slerp(草地_旋轉.transform.localPosition, 草地_旋轉.transform.localPosition, 0.5f);

            //gobj_temp.transform.Translate(n / 10, 0,0);


            gobj_temp.transform.localRotation = Quaternion.Euler(0, 0, n);


            //gobj_temp.name = "草地_旋轉" + n;

            //gobj_temp.gameObject.transform.rotation= Quaternion.Euler(20, 0, 0);

            //gobj.Add(gobj_temp);

        }

    }

    // Update is called once per frame
    void Update()
    {

        //Vector2 vector=Vector2.zero;
        //vector.x = Input.GetAxis("Horizontal") * Time.deltaTime * 10;
        //rBody.velocityX += Input.GetAxis("Horizontal") * Time.deltaTime * 10;
        x = Input.GetAxis("Horizontal") * Time.deltaTime * 10;

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
        rBody.velocityX += x;


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
