using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New profile",menuName = "Profile")]
public class Profile : ScriptableObject
{
    public new string name;
    public string level;
    public Texture2D image;
    public Color32 color;
}
