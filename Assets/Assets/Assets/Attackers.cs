using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attackers : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(-1f, 2f)]
    public float lizardWalkspeed;
    Animator lizardAnim;
    void Start()
    {
        lizardAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if(lizardWalkspeed>0&& lizardWalkspeed<=2f)
        {
            lizardAnim.SetTrigger("Iswalking");
            transform.Translate(Vector3.left * lizardWalkspeed * Time.deltaTime);

        }
    }
}
