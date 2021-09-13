using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    int speedamount = 6;
    SpriteRenderer playerSprite;
    public float x;
    public float y;
    
    void Start()
    {
        playerSprite = GetComponent<SpriteRenderer>();
        

    }
        void Update()
    {

        if (transform.position.x <= x)
        {
            playerSprite.flipX = false;
            speedamount = 6;
        }
        if (transform.position.x >= y)
        {
            playerSprite.flipX = true;
            speedamount = -6;
        }
        transform.Translate(speedamount * Time.deltaTime, 0, 0);
    }
}
