// in the game is called "instruction", im too lazy to change it back
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialManager : MonoBehaviour
{
    public SpriteRenderer box;
    public Sprite tickbox0;
    public Sprite tickbox1;

    public int TutorialState;

    // Update is called once per frame
    void Update()
    {
        TutorialState = PlayerPrefs.GetInt("TutorialState", 1);
        box.sprite = TutorialState == 0 ? tickbox0
           : tickbox1;
    }

    public void changeTutorial()
    {
        TutorialState = TutorialState == 1 ? 0
            : 1;
        PlayerPrefs.SetInt("TutorialState", TutorialState);
    }
}
