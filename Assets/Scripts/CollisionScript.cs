﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    
    player_movemend movemendScript;
    // Start is called before the first frame update
    void Start()
    {
        movemendScript = transform.parent.gameObject.GetComponent<player_movemend>();


    }
    void OnTriggerEnter(Collider other)
    {
        if (gameObject.name == "ColliderCubeRight")
        {
            movemendScript.dontRight = true;
           
        }

        if (gameObject.name == "ColliderCubeLeft")
        {
            movemendScript.dontLeft = true;
          
        }

        if (gameObject.name == "ColliderCubeUp")
        {
            movemendScript.dontUp = true;
            
        }
        if (gameObject.name == "Cube_Vorn")
        {
            movemendScript.panik = true;

        }
        

    }
    void OnTriggerExit(Collider other)
    {
        if (gameObject.name == "ColliderCubeRight")
        {
            movemendScript.dontRight = false;
        }


        if (gameObject.name == "ColliderCubeLeft")
        {
            movemendScript.dontLeft = false;
        }

        if (gameObject.name == "ColliderCubeUp")
        {
            movemendScript.dontUp = false;
        }

        if (gameObject.name == "Cube_Vorn")
        {
            movemendScript.panik = false;

        }


    }
    // Update is called once per frame
    void Update()
    {
        
        


    }
}
