using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainControl : MonoBehaviour
{
    public GameObject playTriangle;
    public GameObject optionsTriangle;
    public GameObject quitTriangle;

    public GameObject MainHolder;
    public GameObject optionsHolder;

    // Start is called before the first frame update
    void Start()
    {
        playTriangle.SetActive(true);
        optionsTriangle.SetActive(false);
        quitTriangle.SetActive(false);

        MainHolder.SetActive(true);
        optionsHolder.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            if (playTriangle.activeInHierarchy == true)
            {
                playTriangle.SetActive(false);
                optionsTriangle.SetActive(true);
            }
            else if(optionsTriangle.activeInHierarchy == true)
            {
                optionsTriangle.SetActive(false);
                quitTriangle.SetActive(true);
            }
            else if(quitTriangle.activeInHierarchy == true)
            {
                return;
            }
        }

        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            if(playTriangle.activeInHierarchy == true)
            {
                return;
            }
            else if(optionsTriangle.activeInHierarchy == true)
            {
                optionsTriangle.SetActive(false);
                playTriangle.SetActive(true);
            }
            else if(quitTriangle.activeInHierarchy == true)
            {
                quitTriangle.SetActive(false);
                optionsTriangle.SetActive(true);
            }
        }
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
