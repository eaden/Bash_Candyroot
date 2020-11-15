using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishScript : MonoBehaviour
{
    Rigidbody finishCube;
 


    // Start is called before the first frame update
    void Start()
    {
        finishCube = GetComponent<Rigidbody>();
    }


    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "PlayerTag")
        {
            Debug.Log("Gewonnen");

        }



    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
