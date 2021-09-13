using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
public class Gamescenecontroller : MonoBehaviour
{
    int highscore = 0;
    public Text HighscoreText;
    public void gotonextscene()
    {
        SceneManager.LoadScene(4);
    }
    public void back()
    {
        SceneManager.LoadScene(1);
    }
    public void help()
    {
        SceneManager.LoadScene(3);
    }
    public void Replay()
    {
        SceneManager.LoadScene(4);
    }
    public void Level2()
    {
        SceneManager.LoadScene(6);
    }
    public void Quit()
    {
        SceneManager.LoadScene(1);
    }
    public void Replaylevel2()
    {
        SceneManager.LoadScene(6);
    }
    void Update()
    {
        int coinscore = PlayerMovement.instance.coinsscore;
        if (coinscore > highscore)
        {
            HighscoreText.text = "Score:" + coinscore;
        }
    }
}
