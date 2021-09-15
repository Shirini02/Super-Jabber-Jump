using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
public class Gamemanager : MonoBehaviour
{
    
    public void gotonextscene()
    {
        SceneManager.LoadScene(4);
    }
   
    public void help()
    {
        SceneManager.LoadScene(3);
    }
    public void back()
    {
        SceneManager.LoadScene(1);
    }

}
