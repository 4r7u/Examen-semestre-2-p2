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
    [SerializeField] private RawImage image;
    [SerializeField] private Color color;

    private void Start()
    {
        title.text = profile.level.ToString();
        nivel.text = profile.level.ToString();

        //gameObject.GetComponent<RawImage>().color = profile.color;
    }

    private void Update()
    {
        gameObject.GetComponent<RawImage>().color = profile.color;
        nivel.text = profile.level.ToString();
    }
}
