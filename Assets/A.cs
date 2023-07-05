using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour
{
    float x = 0;
    int lv = 1;
    private Rigidbody2D rBody;


    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        //Vector2 vector=Vector2.zero;
        //vector.x = Input.GetAxis("Horizontal") * Time.deltaTime * 10;
        rBody.velocityX = Input.GetAxis("Horizontal") * Time.deltaTime * 10;




        //transform.position = vector;
    }
}
