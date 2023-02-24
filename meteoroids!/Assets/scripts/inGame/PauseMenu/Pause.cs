using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pause : MonoBehaviour
{
    public static bool isPaused = false;

    public GameObject pauseMenuUI;
    public GameObject main;
    public GameObject options;

    public GameObject resumeTri;
    public GameObject optionsTri;
    public GameObject Q2MTri;
    public GameObject QuitTri;

    public GameObject resumeButton;

    // Start is called before the first frame update
    void Start()
    {
        main.SetActive(true);
        options.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pausing();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void Pausing()
    {
        pauseMenuUI.SetActive(true);
        main.SetActive(true);
        options.SetActive(false);
        resumeTri.SetActive(true);
        optionsTri.SetActive(false);
        Q2MTri.SetActive(false);
        QuitTri.SetActive(false);
        EventSystem.current.SetSelectedGameObject(resumeButton);
        Time.timeScale = 0f;
        isPaused = true;
    }
}
