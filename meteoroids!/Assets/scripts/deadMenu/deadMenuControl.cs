using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadMenuControl : MonoBehaviour
{
    public GameObject replayTri;
    public GameObject Q2MTri;
    public GameObject QuitTri;

    // Start is called before the first frame update
    void Start()
    {
        replayTri.SetActive(true);
        Q2MTri.SetActive(false);
        QuitTri.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            if (replayTri.activeInHierarchy == true)
            {
                replayTri.SetActive(false);
                Q2MTri.SetActive(true);
            }
            else if (Q2MTri.activeInHierarchy == true)
            {
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
            if (replayTri.activeInHierarchy == true)
            {
                return;
            }
            else if (Q2MTri.activeInHierarchy == true)
            {
                Q2MTri.SetActive(false);
                replayTri.SetActive(true);
            }
            else if (QuitTri.activeInHierarchy == true)
            {
                QuitTri.SetActive(false);
                Q2MTri.SetActive(true);
            }
        }
    }
}
