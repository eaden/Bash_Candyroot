using System.Collections;
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
        movemendScript.dontRight = true;


    }
    void OnTriggerExit(Collider other)
    {
        movemendScript.dontRight = false;


    }
    // Update is called once per frame
    void Update()
    {
        
        


    }
}
