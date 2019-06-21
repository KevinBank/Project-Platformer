using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{

    public void loadLevel01()
    {
        SceneManager.LoadScene("Level01", LoadSceneMode.Single);
    }
    public void loadHelp()
    {
        SceneManager.LoadScene("Help", LoadSceneMode.Single);
    }
    public void loadStartScreen()
    {
        SceneManager.LoadScene("Start", LoadSceneMode.Single);
    }
}
