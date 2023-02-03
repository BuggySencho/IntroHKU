using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public Animator menuUI;
    public GameObject gameUI;

    public void Start()
    {
        Time.timeScale = 0;
    }

    public void StartButton()
    {
        Time.timeScale = 1;
        gameUI.SetActive(true);
        menuUI.Play("Fade");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
