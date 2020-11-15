using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerfolgerScript : MonoBehaviour
{
    Rigidbody rigiVerfolger;
    GameObject player;
    float velocity;

    

    // Start is called before the first frame update
    void Start()
    {
        player = transform.Find("Player").gameObject;
        rigiVerfolger = GetComponent<Rigidbody>();
       
    }
    void OnCollisionTag(Collider other)
    {
        if (gameObject.name == "Player")
        {
            Debug.Log("VERLOREN");

        }



    }
    // Update is called once per frame
    void Update()
    {
        rigiVerfolger.velocity = new Vector3(rigiVerfolger.velocity.x, rigiVerfolger.velocity.y, -2f);
    }
}
