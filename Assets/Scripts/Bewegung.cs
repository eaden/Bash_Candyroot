using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bewegung : MonoBehaviour
{
    float posx = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            
            if (posx < 2)
            {
                posx += 1f;
                gameObject.transform.position += new Vector3(1f, 0f, 0f);
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (posx > 0)
            {
                posx -= 1f;
                gameObject.transform.position += new Vector3(-1f, 0f, 0f);
            } 
        }
    }
}
