using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerPrefSave : MonoBehaviour
{
    [SerializeField] private RawImage img;
    [SerializeField] private Texture2D[] texture;
    [SerializeField] private TMP_Text textName;

    private int imgCount;
    private new string name;

    private void Awake()
    {
        imgCount = PlayerPrefs.GetInt("img");
        name = PlayerPrefs.GetString("name");
    }

    private void Update()
    {
        imgCount = PlayerPrefs.GetInt("img");
        name = PlayerPrefs.GetString("name");
        img.texture = texture[imgCount];
        textName.text = name;
    }

    public void EraseInfo ()
    {
        SceneManager.LoadScene(0);        
    }
}
