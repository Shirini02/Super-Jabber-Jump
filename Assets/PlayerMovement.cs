using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float playerSpeed;
    public float jumpSpeed;
    public bool isGrounded;
    Animator animator;
    //SpriteRenderer spriteRenderer;
    public bool playerMove = true;
    public int coinsscore = 0;
    public Text scoreText;
    public static PlayerMovement instance;
    public GameObject coineffects;
    AudioSource coinaudio;
    public AudioClip coinsound;

    public void Awake()
    {

        instance = this;

    }






    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        coinaudio = GameObject.Find("AudioManager").GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        if (playerMove == true)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                

                    rb.velocity = new Vector2(playerSpeed, 0);

                    animator.SetTrigger("Run");
                
                

            }
           
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.velocity = new Vector2(-playerSpeed, 0);



                animator.SetTrigger("Run");

            }
            
               
            

            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (isGrounded == true)
                {
                    Jump();
                    

                   


                }
               // animator.SetTrigger("Idle");
                // animator.SetTrigger("Run");
            }
           



        }


    }


    public void Jump()
    {
        rb.velocity = new Vector2(0, jumpSpeed);
        animator.SetTrigger("Jump");
        isGrounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        if (collision.gameObject.tag == "Obstacle")
        {
           // animator.SetTrigger("Idle");
        }

        if (collision.gameObject.tag == "Saw")
        {
            animator.SetTrigger("Dead");
        }
        if (collision.gameObject.tag == "Brick")
        {
            animator.SetTrigger("Idle");
            animator.SetTrigger("Jump");
        }
        if (collision.gameObject.tag == "Saw" || collision.gameObject.tag == "Enemy1" || collision.gameObject.tag == "Enemy2" || collision.gameObject.tag == "Gameover")
        {
            SceneManager.LoadScene(7);
        }
        if (collision.gameObject.tag == "Level2enemies")
        {
            SceneManager.LoadScene(9);
        }
        if (collision.gameObject.tag == "Level2Obstacles")
        {
            SceneManager.LoadScene(9);
        }
        if (collision.gameObject.tag == "Flag")
        {
            SceneManager.LoadScene(5);
        }
        if (collision.gameObject.tag == "Flag1")
        {
            SceneManager.LoadScene(8);
        }



    }
    public void incrementscore()
    {
        coinsscore = coinsscore + 10;
        scoreText.text = "Score:" + coinsscore;
        print("\n");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coins")
        {
            collision.gameObject.SetActive(false);
            coineffects.SetActive(true);
            Invoke("StopParticle", 1f);
            coinaudio.clip = coinsound;
            coinaudio.Play();

            incrementscore();
        }

    }
    public void StopParticle()
    {
        coineffects.SetActive(false);
    }
}

