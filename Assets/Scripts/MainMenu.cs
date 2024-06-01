using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Profile profile;

   public void PlayGame()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Jugar");
    }
    
    public void Prefs()
    {
        SceneManager.LoadScene(2);
    }

    public void Quit()
    {
        Application.Quit();
    }

    private void Start()
    {

    }

}
