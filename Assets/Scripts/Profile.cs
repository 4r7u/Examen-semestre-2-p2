using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New profile",menuName = "Profile")]
public class Profile : ScriptableObject
{
    public string name;
    public string level;
    public Sprite image;
    public Color color;
}
