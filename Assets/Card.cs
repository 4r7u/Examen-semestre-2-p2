using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New card",menuName = "Card")]
public class Card : ScriptableObject
{
    public new string name;
    public string description;
    public string typetype;
    public int atk;
    public int def;
    public Sprite image;
    public Sprite type;
    public Sprite stars;
    public Color color;
}
