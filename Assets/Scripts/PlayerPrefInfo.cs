using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPrefInfo : MonoBehaviour
{
    [SerializeField] private new TMP_Text name;
    [SerializeField] private Profile profile;
    private int img;

    public void ImageChangeBtn (int _img)
    {
        img = _img;
        PlayerPrefs.SetInt("img", img);
    }

    public void SaveInfo ()
    {
        PlayerPrefs.SetInt("img",img);
        PlayerPrefs.SetString("name",name.text);

        profile.name = name.text;
    }
}
