﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movemend : MonoBehaviour
{
        float duckingTimeLimit = 2;
        float duckingTime = 2;
        GameObject childcube;
        bool isJumping = false;
        bool isDucking = false;
        Rigidbody rigi;
        private float posx;
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


        rigi.velocity = new Vector3(rigi.velocity.x, rigi.velocity.y, -2f);
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (posx < 2)
            {
                posx = posx + 1f;
               gameObject.transform.position += new Vector3(1.5f, 0f, 0f);
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (posx > 0)
            {
                posx = posx - 1f;
                gameObject.transform.position += new Vector3(-1.5f, 0f, 0f);
            }
            
        }
        if(Input.GetKeyDown(KeyCode.UpArrow) && isJumping == false && isDucking == false)
        {
            rigi.AddForce(new Vector3(0f, 8f, 0f),ForceMode.VelocityChange);
            isJumping = true;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && isJumping == false && isDucking == false)
        {
            

            childcube.SetActive(false);
            isDucking = true;
           

        }
        if(isDucking == true)
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
