using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectpooling : MonoBehaviour
{
    public GameObject bullet;
    public GameObject currentbullet;
    Stack<GameObject> BulletPool = new Stack<GameObject>();
    Animator animator;
    private static Objectpooling instance;
    AudioSource bulletaudio;
    // take gameobject
    public GameObject particlesystem;
    public AudioClip bulletsound;

   

   
    // Update is called once per frame
   
    public static Objectpooling Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<Objectpooling>();
            }
            return instance;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        bulletaudio = GameObject.Find("AudioManager").GetComponent<AudioSource>();
       
    }

    // Update is called once per frame
    void Update()
    {
      

        if (Input.GetKeyDown(KeyCode.Space))
            {
                print("Space pressed");
            //enable gameobject
            particlesystem.SetActive(true);
            //system.Play();
            animator.SetTrigger("Shoot");
            CreateBullet();
            

            bulletaudio.clip = bulletsound;
            bulletaudio.Play();
            Invoke("StopParticleSystem", 1f);
        }
    }
   
   
    public void StopParticleSystem()
    {
        particlesystem.SetActive(false);
    }
    public void CreatePool()
    {
       
        BulletPool.Push(Instantiate(bullet));
        BulletPool.Peek().SetActive(false);
        BulletPool.Peek().name = "Bullet";




    }
    public void AddBulletToPool(GameObject bullettemp)
    {
        BulletPool.Push(bullettemp);
        BulletPool.Peek().SetActive(false);
    }
    public void CreateBullet()
    {
        if (BulletPool.Count == 0)
        {
           
            CreatePool();
        }
        GameObject temp = BulletPool.Pop();
        temp.SetActive(true);
        temp.transform.position =  transform.position;
        currentbullet = temp;
    }
}
