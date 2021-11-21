// GameDev.tv ChallengeClub.Got questionsor wantto shareyour niftysolution?
// Head over to - http://community.gamedev.tv

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PresetColor
{
    Red = 0xFF0000,
    Green = 0x00FF00,
    Blue = 0x0000FF,
    Yellow = 0xFFFF00
}
public class ColorChanger : MonoBehaviour
{
    private SpriteRenderer mySpriteRenderer;
    public PresetColor color;


    void Awake()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        Color theColor;
        if (ColorUtility.TryParseHtmlString(color.ToString(), out theColor))
        {
            mySpriteRenderer.color = theColor;
        }

    }
}
