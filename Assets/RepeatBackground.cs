using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    public static RepeatBackground instance;
    Material bgMat,clouds;
    
    public float xoffset;
    Animator anim;

    private void Awake()
    {
        instance = this;
    }


    void Start()
    {
        bgMat = GetComponent<MeshRenderer>().material;
        
        anim = GetComponent<Animator>();
        

    }


    void Update()
    {
        bgMat.mainTextureOffset = new Vector2(xoffset * Time.time, 0);


    }
}
