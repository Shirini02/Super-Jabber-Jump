using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaclemove : MonoBehaviour
{
    int speedamount = 2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x <= 58)
        {
            speedamount = 2;
        }
        if (transform.position.x >= 64)
        {
            speedamount = -2;
        }
        transform.Translate(speedamount * Time.deltaTime, 0, 0);



    }
}
