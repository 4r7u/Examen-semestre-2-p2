using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    private bool gameIsPaused;
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private Profile profile;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            gameIsPaused = !gameIsPaused;
            PauseGame();
        }
    }

    void PauseGame() //Pausar juego
    {
        if (gameIsPaused)
        {
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    public void ReturnMenu() //Regresar a men� principal
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

}
