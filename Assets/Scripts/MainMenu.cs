using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject tutorials;

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Play()
    {
        PlayerPrefs.SetInt("scoreData", 0);
        SceneManager.LoadScene("chapterOne");
    }

    public void HowtoPlay()
    {
        tutorials.SetActive(true);
    }


    public void OnApplicationQuit()
    {
        Application.Quit();
    }


}
