using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class whenDead : MonoBehaviour
{
    public void dead()
    {
        PlayerPrefs.SetInt("NewScore", Scored.Score);
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(2);
    }
}
