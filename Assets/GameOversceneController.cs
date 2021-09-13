using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScene : MonoBehaviour
{
    public GameObject toppanel, middlepanel, helppanel, optionspanel;


    public void GoToNextScene()
    {
        SceneManager.LoadScene(0);
    }

    public void back()
    {
        toppanel.SetActive(true);
        middlepanel.SetActive(true);
        helppanel.SetActive(false);
        optionspanel.SetActive(false);

    }
    public void Help()
    {
        helppanel.SetActive(true);
        toppanel.SetActive(false);
        middlepanel.SetActive(false);

    }
    public void options()
    {
        optionspanel.SetActive(true);
        toppanel.SetActive(false);
        middlepanel.SetActive(false);
        helppanel.SetActive(false);

    }

}
