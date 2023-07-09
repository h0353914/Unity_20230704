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
    public GameObject 草地_super;



    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        Big = GetComponent<Animator>();
        GameObject gobj_super = 草地_super;
        int n = 1;
        float r = 3f;
        while (300 / r > n)
        {
            GameObject copy草地 = Instantiate(gobj_super);
            copy草地.transform.parent = gobj_super.transform;
            copy草地.transform.localPosition = new Vector3(1f, 0, 0);
            copy草地.transform.localRotation = Quaternion.Euler(0, 0, r);
            copy草地.name = "草地_copy" + n;
            gobj_super = copy草地;

            n++;
        }
    }
    void Update()
    {

        x = Input.GetAxis("Horizontal") * Time.deltaTime * 200;

        //if (Input.GetAxisRaw("Horizontal") == 1)
        //{

        //    Big.SetBool("go", true);
        //}
        //else
        //{
        //    Big.SetBool("stop",true);
        //}
        if (草地bool && Input.GetAxisRaw("Jump") == 1)
        {
            草地bool = false;
            //rBody.velocityY = 6;
            rBody.AddForce(new Vector2(0, 350));


        }
        rBody.velocityX += x;
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "草地")
        {
            草地bool = true;
        }
    }
}
