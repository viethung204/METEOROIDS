using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PauseController : MonoBehaviour
{
    public GameObject resumeTri;
    public GameObject optionsTri;
    public GameObject Q2MTri;
    public GameObject QuitTri;

    public GameObject  Resume;

    AudioSource selecting;

    // Start is called before the first frame update
    void Start()
    {
        resumeTri.SetActive(true);
        optionsTri.SetActive(false);
        Q2MTri.SetActive(false);
        QuitTri.SetActive(false);

        EventSystem.current.SetSelectedGameObject(Resume);

        selecting = GameObject.Find("AudioManager").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            if (resumeTri.activeInHierarchy == true)
            {
                selecting.Play();
                resumeTri.SetActive(false);
                optionsTri.SetActive(true);
            }
            else if (optionsTri.activeInHierarchy == true)
            {
                selecting.Play();
                optionsTri.SetActive(false);
                Q2MTri.SetActive(true);
            }
            else if (Q2MTri.activeInHierarchy == true)
            {
                selecting.Play();
                Q2MTri.SetActive(false);
                QuitTri.SetActive(true);
            }
            else if (QuitTri.activeInHierarchy == true)
            {
                return;
            }
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            if (resumeTri.activeInHierarchy == true)
            {
                return;
            }
            else if (optionsTri.activeInHierarchy == true)
            {
                selecting.Play();
                optionsTri.SetActive(false);
                resumeTri.SetActive(true);
            }
            else if (Q2MTri.activeInHierarchy == true)
            {
                selecting.Play();
                Q2MTri.SetActive(false);
                optionsTri.SetActive(true);
            }
            else if (QuitTri.activeInHierarchy == true)
            {
                selecting.Play();
                QuitTri.SetActive(false);
                Q2MTri.SetActive(true);
            }
        }
    }
}
