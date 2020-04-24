using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ScriptForLevelSelection : MonoBehaviour
{
    public void MainScene()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void Level01()
    {
        SceneManager.LoadScene("Level01Selection");
    }

    public void Level02()
    {
        SceneManager.LoadScene("Level02Selection");
    }

    public void Level03()
    {
        SceneManager.LoadScene("Level03Selection");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
