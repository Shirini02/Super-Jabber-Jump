using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdmovement : MonoBehaviour
{
    public float obstaclespeed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //rb.AddForce(Vector2.left * obstaclespeed*Time.deltaTime);
        rb.velocity = Vector2.left * obstaclespeed;
    }
    private void OnBecameInvisible()
    {
        this.gameObject.SetActive(false);
    }
}
