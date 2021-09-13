using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{

    Rigidbody2D rbbullet;
    float bulletspeed = 20.0f;
    //public ParticleSystem system;

    // Start is called before the first frame update
    void Start()
    {
        rbbullet = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        rbbullet.velocity = Vector3.right * bulletspeed;
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine("BulletAddToPool");
        if (collision.gameObject.tag == "Enemy1" || collision.gameObject.tag == "Enemy2"||collision.gameObject.tag=="Bird" )
        {

            Destroy(collision.gameObject);
        }


    }
    IEnumerator BulletAddToPool()
    {
        yield return new WaitForSeconds(1);

        if (rbbullet.gameObject.name == "Bullet")
        {
            Objectpooling.Instance.AddBulletToPool(rbbullet.gameObject);
            //Objectpooling.Instance.system.Play();

        }
    }
}
