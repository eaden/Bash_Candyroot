using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZungenSprite : MonoBehaviour
{
    public Sprite[] Zunge = new Sprite[4];
    SpriteRenderer sp;
    int legIndex = 0;
    float legTime = 0.125f;
    float legTimeLimit = 0.125f;
    // Start is called before the first frame update
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        legTime -= Time.deltaTime;
        if (legTime < 0)
        {
            legTime = legTimeLimit;
            legIndex = SpriteIndex(Zunge, legIndex);
            sp.sprite = Zunge[legIndex];
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
