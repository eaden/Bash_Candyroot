using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteScript : MonoBehaviour
{
    float legTime = 0.4f;
    float legTimeLimit = 0.4f;
    SpriteRenderer sp;
    SpriteRenderer sp_bodies;
    SpriteRenderer sp_arms;
    SpriteRenderer sp_face;
    public Sprite[] legs = new Sprite[2];
    public Sprite[] bodies = new Sprite[3];
    [SerializeField]
    public Sprite[] armses = new Sprite[8];
    public Sprite[] face = new Sprite[2];

    player_movemend player;

    int legIndex = 0;

    int legStand = 0;

    // Start is called before the first frame update
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        sp_bodies = transform.Find("BodySprite").GetComponent<SpriteRenderer>();
        sp_arms = transform.Find("ArmsSprite").GetComponent<SpriteRenderer>();
        sp_face = transform.Find("FaceSprite").GetComponent<SpriteRenderer>();
        player = transform.parent.gameObject.GetComponent<player_movemend>();

    }

    // Update is called once per frame
    void Update()
    {
        legTime -= Time.deltaTime;
        if (legTime < 0)
        {
                legTime = legTimeLimit;
                legIndex = SpriteIndex(legs, legIndex);
                sp.sprite = legs[legIndex];
                sp_arms.sprite = armses[legIndex];
            /*
            }
            else
            {
                sp_arms.sprite = null;
                sp.sprite = null;
            }
            */

        }
        // vorher 0.03
        // dann -0.864
        // dann -0.894
        if (player.isDucking)
        {
            //sp_bodies.sprite = bodies[1];
            //sp.gameObject.transform.position = new Vector3(sp_bodies.gameObject.transform.position.x, -0.864f, sp_bodies.gameObject.transform.position.z);
        }
        else
            //sp.gameObject.transform.position = new Vector3(sp_bodies.gameObject.transform.position.x, 0.03f, sp_bodies.gameObject.transform.position.z);
        if (player.isJumping)
        {
            //sp_bodies.sprite = bodies[2];
        }



    }

    int SpriteIndex(Sprite[] s, int currentIndex)
    {
        if (currentIndex == s.Length - 1)
            currentIndex = 0;
        else
            currentIndex++;
        return currentIndex;
    }
}
