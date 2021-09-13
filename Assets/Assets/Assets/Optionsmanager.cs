using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Optionsmanager : MonoBehaviour
{
    public Slider volumeSlider;
    public Slider difficultySlider;
    private AudioManager audioManager;


    // Start is called before the first frame update
    void Start()
    {
        print(PlayerPrefsManager.GetMasterVolume());
        print(PlayerPrefsManager.GetDifficulty());
        volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
        difficultySlider.value = PlayerPrefsManager.GetDifficulty();
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
        //audioManager = GameObject.FindObjectOfType<AudioManager>();
      
    }

    // Update is called once per frame
    void Update()
    {
        audioManager.SetVolume("Bullet", volumeSlider.value);
        print(PlayerPrefsManager.GetMasterVolume());
        print(PlayerPrefsManager.GetDifficulty());

    }

    public void SaveAndExit()
    {
        //PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
        //print(PlayerPrefsManager.GetMasterVolume());
        //PlayerPrefsManager.SetDifficulty(difficultySlider.value);
        //print(PlayerPrefsManager.GetDifficulty());
        //SceneManager.LoadScene(1);
    }

    public void SetDefaults()
    {
        volumeSlider.value = 0.3f;
        difficultySlider.value = 0.3f;
    }
   
}
