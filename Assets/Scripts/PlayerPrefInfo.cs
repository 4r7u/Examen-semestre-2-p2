using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefInfo : MonoBehaviour
{
    [SerializeField] private new TMP_Text name;
    private int img;

    public void ImageChangeBtn (int _img)
    {
        img = _img;
    }

    public void SaveInfo ()
    {
        PlayerPrefs.SetInt("img",img);
        PlayerPrefs.SetString("name",name.text);
        SceneManager.LoadScene(0);
    }
}
