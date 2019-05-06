using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{

    public void loadLevel01()
    {
        SceneManager.LoadScene("Level01");
    }
    public void loadHelp()
    {
        SceneManager.LoadScene("Help");
    }
}
