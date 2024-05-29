using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class profileManager : MonoBehaviour
{
    [SerializeField] private Profile profile;
    [SerializeField] private TMP_Text title;
    [SerializeField] private TMP_Text nivel;
    [SerializeField] private Image image;
    [SerializeField] private Color color;

    private void Start()
    {
        title.text = profile.level.ToString();
        //image.sprite = profile.image;
        nivel.text = profile.level;
        
        //gameObject.GetComponent<Image>().color = profile.color;
    }
}
