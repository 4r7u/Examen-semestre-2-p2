using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UITween : MonoBehaviour
{
    [SerializeField]
    private GameObject menuTitle, menuBtnContainer;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.scale(menuTitle, new Vector3(1, 1, 1), 1).setEase(LeanTweenType.easeInExpo).setDelay(.3f);
        LeanTween.scale(menuBtnContainer, new Vector3(1, 1, 1), 1).setEase(LeanTweenType.easeInExpo).setDelay(.3f);
        //LeanTween.scale(menuTitle, new Vector3(1.1f, 1.1f, 1.1f), 1).setLoopPingPong();
    }





}
