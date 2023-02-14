using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optionsControl : MonoBehaviour
{
    public GameObject volumeTri;
    public GameObject CRTTri;
    public GameObject resetTri;
    public GameObject backTri;

    // Start is called before the first frame update
    void Start()
    {
        volumeTri.SetActive(true);
        CRTTri.SetActive(false);
        resetTri.SetActive(false);
        backTri.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            if(volumeTri.activeInHierarchy == true)
            {
                volumeTri.SetActive(false);
                CRTTri.SetActive(true);
            }
            else if(CRTTri.activeInHierarchy == true)
            {
                CRTTri.SetActive(false);
                resetTri.SetActive(true);
            }
            else if(resetTri.activeInHierarchy == true)
            {
                resetTri.SetActive(false);
                backTri.SetActive(true);
            }
            else if(backTri.activeInHierarchy == true)
            {
                return;
            }
        }

        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            if(volumeTri.activeInHierarchy == true)
            {
                return;
            }
            else if(CRTTri.activeInHierarchy == true)
            {
                CRTTri.SetActive(false);
                volumeTri.SetActive(true);
            }
            else if(resetTri.activeInHierarchy == true)
            {
                resetTri.SetActive(false);
                CRTTri.SetActive(true);
            }
            else if(backTri.activeInHierarchy == true)
            {
                backTri.SetActive(false);
                resetTri.SetActive(true);
            }
        }
    }
}
