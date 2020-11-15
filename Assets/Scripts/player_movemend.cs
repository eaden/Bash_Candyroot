using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movemend : MonoBehaviour
{
       public bool dontUp = false;
       public bool dontRight = false;
       public bool dontLeft = false;
        float duckingTimeLimit = 2;
        float duckingTime = 2;
        GameObject childcube;
       public bool isJumping = false;
       public bool isDucking = false;
        Rigidbody rigi;
        private float posx;
    public bool panik = false;
    // Start is called before the first frame update


    void Start()
    {
        childcube = transform.Find("ChildCube").gameObject;
        rigi = GetComponent<Rigidbody>();
        posx = 1;
        GetComponent<FixedJoint>().connectedBody = childcube.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }


        rigi.velocity = new Vector3(rigi.velocity.x, rigi.velocity.y, -2f);
        if(Input.GetKeyDown(KeyCode.RightArrow) && !dontRight)
        {
            
            if (posx < 2)
            {
                posx = posx + 1f;
               gameObject.transform.position += new Vector3(1.5f, 0f, 0f);
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && !dontLeft)
        {
            if (posx > 0)
            {
                posx = posx - 1f;
                gameObject.transform.position += new Vector3(-1.5f, 0f, 0f);
            }
            
        }
        if(Input.GetKeyDown(KeyCode.UpArrow) && isJumping == false && isDucking == false)
        {
            rigi.AddForce(new Vector3(0f, 10.5f, 0f),ForceMode.VelocityChange);
            isJumping = true;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && isJumping == false && isDucking == false)
        {
            

            childcube.SetActive(false);
            isDucking = true;
           

        }
        if(isDucking == true && !dontUp)
        {
            duckingTime -= Time.deltaTime;
        }
        
        
        if (duckingTime < 0)
        {
            isDucking = false;
            duckingTime = duckingTimeLimit;
            childcube.SetActive(true);
        }


    }
       void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Floor")
        {
            isJumping = false;
        }

    }
   
    }

