// in the game is called "instruction", im too lazy to change it back
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tut : MonoBehaviour
{
    public int tutStat;
    public GameObject tutText;

    // Start is called before the first frame update
    void Start()
    {
        tutStat = PlayerPrefs.GetInt("TutorialState");
    }

    // Update is called once per frame
    void Update()
    {
        if(tutStat == 1)
        {
            tutText.SetActive(true);
        }
        else
        {
            tutText.SetActive(false);
        }
    }
}
