using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            if(gameObject.name == "Level1Finish")
                SceneManager.LoadScene("NextLevel");
            else
                SceneManager.LoadScene("Ende");
        }



    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
