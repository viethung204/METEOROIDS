using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deadMenuManager : MonoBehaviour
{
    public void Replay()
    {
        SceneManager.LoadScene(1);
    }

    public void Q2M()
    {
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
