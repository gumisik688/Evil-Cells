using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Demo");
        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
