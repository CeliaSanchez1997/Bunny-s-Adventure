using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pausemenuUI;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void Resume()
    {
        pausemenuUI.SetActive(false);
        Time.timeScale = 1;
        GameIsPaused = false;
    }

    void Pause()
    {
        pausemenuUI.SetActive(true);
        Time.timeScale = 0;
        GameIsPaused = true;
    }

    public void LevelSelection()
    {
        SceneManager.LoadScene("levelSelection");
    }


    public void Quit()
    {
        Application.Quit();
    }

    public void ReplayScene1()
    {
        SceneManager.LoadScene("Level01");
    }


    public void ReplayScene2()
    {
        SceneManager.LoadScene("Level02");
    }

    public void MainScene()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void ReplayBoss()
    {
        SceneManager.LoadScene("boss level");
    }

    public void ReplayScene3()
    {
        SceneManager.LoadScene("Level03");
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

}
