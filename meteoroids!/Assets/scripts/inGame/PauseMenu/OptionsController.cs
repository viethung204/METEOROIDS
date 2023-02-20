using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class OptionsController : MonoBehaviour
{
    public GameObject volumeTri;
    public GameObject CRTTri;
    public GameObject backTri;

    AudioSource selecting;

    // Start is called before the first frame update
    void Start()
    {
        volumeTri.SetActive(true);
        CRTTri.SetActive(false);
        backTri.SetActive(false);

        selecting = GameObject.Find("AudioManager").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            if (volumeTri.activeInHierarchy == true)
            {
                selecting.Play();
                volumeTri.SetActive(false);
                CRTTri.SetActive(true);
            }
            else if (CRTTri.activeInHierarchy == true)
            {
                selecting.Play();
                CRTTri.SetActive(false);
                backTri.SetActive(true);
            }
            else if (backTri.activeInHierarchy == true)
            {
                return;
            }
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            if (volumeTri.activeInHierarchy == true)
            {
                return;
            }
            else if (CRTTri.activeInHierarchy == true)
            {
                selecting.Play();
                CRTTri.SetActive(false);
                volumeTri.SetActive(true);
            }
            else if (backTri.activeInHierarchy == true)
            {
                selecting.Play();
                backTri.SetActive(false);
                CRTTri.SetActive(true);
            }
        }
    }
}
