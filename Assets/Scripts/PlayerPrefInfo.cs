using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerPrefInfo : MonoBehaviour
{
    [SerializeField] private new TMP_Text name;
    [SerializeField] private Profile profile;
    [SerializeField] private Texture2D[] texture;
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
        profile.image = texture[img];
        profile.level = 0;

        if (img == 0)
        {
            profile.color = new Color32(247, 201, 114, 255);            
        } else
        {
            profile.color = new Color32(202, 119, 227, 255);
        }
    }
}
