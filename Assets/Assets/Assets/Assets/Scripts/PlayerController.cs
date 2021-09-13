using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().PlayAudio("Bullet");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            AudioManager.instance.StopPlayAudio("Bullet");
            FindObjectOfType<AudioManager>().PlayAudio("Death");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
