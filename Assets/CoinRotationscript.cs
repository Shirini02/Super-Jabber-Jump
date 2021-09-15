using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotationscript : MonoBehaviour
{
    private float rotateSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(transform.up, 360 * rotateSpeed * Time.deltaTime);
    }
}
