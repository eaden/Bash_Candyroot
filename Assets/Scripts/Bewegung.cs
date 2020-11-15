using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bewegung : MonoBehaviour
{
    float posx = 1f;
    Rigidbody rigi;
    bool isJumping = false;

    // Start is called before the first frame update
    void Start()
    {
        rigi = GetComponent<Rigidbody>();
    }


    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Floor")
        {
            isJumping = false;
        }


    }


    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
    }


    
    // Update is called once per frame
    void Update()
    {
        rigi.velocity = new Vector3(rigi.velocity.x, rigi.velocity.y, -2f);

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            
            if (posx < 2)
            {
                posx += 1f;
                gameObject.transform.position += new Vector3(1.5f, 0f, 0f);
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (posx > 0)
            {
                posx -= 1f;
                gameObject.transform.position += new Vector3(-1.5f, 0f, 0f);
            } 
        }

        //springen
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (posx > 0)
            {
                posx -= 1f;
                gameObject.transform.position += new Vector3(0f, -1f, 0f);
            }
        }

        //ducken
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rigi.AddForce(new Vector3(0f, 8f, 0f),ForceMode.VelocityChange);
        }

    }
}
