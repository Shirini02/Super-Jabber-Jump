using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    Transform playerTransform;
    [SerializeField] Vector3 offset;
    float delayspeed = 10f;
   
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float yoffset = playerTransform.transform.position.x;
        float xoffset = playerTransform.transform.position.y;

        //float xoffset = playerTransform.transform.position.y;

        //Vector3 camposition = playerTransform.position + (offset - new Vector3(0f,yoffset,0f));
        Vector3 camposition = offset - new Vector3(-yoffset, -xoffset, 0f);
  


        transform.position = Vector3.Slerp(transform.position, camposition, Time.deltaTime * delayspeed);
       // transform.position = Vector3.Lerp(transform.position, a, Time.deltaTime * delayspeed);

    }
}
