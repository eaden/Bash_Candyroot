using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VerfolgerScript : MonoBehaviour
{
    Rigidbody rigiVerfolger;
    GameObject player;
    

    

    // Start is called before the first frame update
    void Start()
    {
        //player = transform.Find("Player").gameObject;
        rigiVerfolger = GetComponent<Rigidbody>();
       
    }
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "PlayerTag")
        {
            SceneManager.LoadScene("Geschleckt"); 

        }



    }
    // Update is called once per frame
    void Update()
    {
        rigiVerfolger.velocity = new Vector3(rigiVerfolger.velocity.x, rigiVerfolger.velocity.y, -2f);
    }
}
