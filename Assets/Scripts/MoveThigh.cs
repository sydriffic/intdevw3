using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveThigh : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody2D myBody;
    float power = 0.2f;
    void Start()
    {
         myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {
        
        if(myBody.gameObject.tag == "L")
        {
            if(Input.GetKey(KeyCode.Q))
            {
                myBody.AddForce(transform.right * power, ForceMode2D.Impulse);
            }
        }
        else if(myBody.gameObject.tag == "R")
        {
            if(Input.GetKey(KeyCode.W))
            {
                myBody.AddForce(transform.right * power, ForceMode2D.Impulse);
            }
        }
    }
}
