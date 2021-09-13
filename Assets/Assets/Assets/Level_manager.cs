using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_manager : MonoBehaviour
{
    public float autoLoadLevelTimer;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            Invoke("LoadNextLevel", autoLoadLevelTimer);
        }
    }

    [System.Obsolete]
    public void LoadNextLevel(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void LoadPreviousLevel(string name)
    {
        SceneManager.LoadScene(name);
    }
    public void Quit()
    {
        Application.Quit();
    }

    [System.Obsolete]
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);  
    }
    public void LoadPreviousLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
