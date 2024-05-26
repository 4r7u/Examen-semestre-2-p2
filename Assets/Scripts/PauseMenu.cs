using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MainMenu
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public Button FirstSelected;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetButtonDown("OpenMenu"))
        {
            Debug.Log("Pause");
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        GameIsPaused = true;
        FirstSelected.Select();
    }

    public void Menu()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }

    public void Salir()
    {
        Application.Quit();
    }

}

    


