using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void MainScene()
    {
        SceneManager.LoadScene("Main Menu");
    }

    //story mode
    public void ReplayScene1()
    {
        SceneManager.LoadScene("Level01");
    }

    public void NextLevelScene1()
    {
        SceneManager.LoadScene("Level02");
    }

    public void ReplayScene2()
    {
        SceneManager.LoadScene("Level02");
    }

    public void NextLevelScene2()
    {
        SceneManager.LoadScene("Level03");
    }

    public void ReplayScene3()
    {
        SceneManager.LoadScene("Level03");
    }

    public void NextLevelScene3()
    {
        SceneManager.LoadScene("boss level");
    }

    //on for level selection
    public void ReplayScene1selection()
    {
        SceneManager.LoadScene("Level01Selection");
    }

    public void NextLevelScene1Selection()
    {
        SceneManager.LoadScene("Level02Selection");
    }

    public void ReplayScene2selection()
    {
        SceneManager.LoadScene("Level02Selection");
    }

    public void NextLevelScene2selection()
    {
        SceneManager.LoadScene("Level03Selection");
    }

    public void ReplayScene3selection()
    {
        SceneManager.LoadScene("Level03Selection");
    }

    public void NextLevelScene3selection()
    {
        SceneManager.LoadScene("Level01");
    }

    public void LevelSelection()
    {
        SceneManager.LoadScene("levelSelection");
    }


    public void StoryMode()
    {
        SceneManager.LoadScene("StoryIntro");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
