using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
    [SerializeField] private Card card;
    [SerializeField] private TMP_Text title;
    [SerializeField] private TMP_Text description;
    [SerializeField] private TMP_Text atk;
    [SerializeField] private TMP_Text def;
    [SerializeField] private TMP_Text typetype;
    [SerializeField] private Image image;
    [SerializeField] private Image type;
    [SerializeField] private Image stars;
    [SerializeField] private Color color;

    private void Start()
    {
        title.text = card.name;
        description.text = card.description;
        atk.text = "ATK/ " + card.atk.ToString();
        def.text = "DEF/ " + card.def.ToString();
        typetype.text = card.typetype.ToString();

        image.sprite = card.image;
        type.sprite = card.type;
        stars.sprite = card.stars;

        gameObject.GetComponent<Image>().color = card.color;
    }
}
