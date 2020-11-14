using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteScript : MonoBehaviour
{
    float legTime = 0.4f;
    float legTimeLimit = 0.4f;
    SpriteRenderer sp;
    SpriteRenderer sp_body;
    SpriteRenderer sp_arms;
    SpriteRenderer sp_face;
    public Sprite[] legs = new Sprite[2];
    public Sprite[] bodies = new Sprite[3];
    public Sprite[] arms = new Sprite[2];
    public Sprite[] face = new Sprite[2];

    int legIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        sp_body = transform.Find("BodySprite").GetComponent<SpriteRenderer>();
        sp_arms = transform.Find("ArmsSprite").GetComponent<SpriteRenderer>();
        sp_face = transform.Find("FaceSprite").GetComponent<SpriteRenderer>();
        
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
            sp_arms.sprite = arms[legIndex];
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
