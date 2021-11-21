// GameDev.tv ChallengeClub.Got questionsor wantto shareyour niftysolution?
// Head over to - http://community.gamedev.tv

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private SpriteRenderer mySpriteRenderer;
    public bool activate;
    public string colorVal = "#FFFFFF";


    void Awake()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        if (activate)
        {
            var theColor = new Color();

            // mySpriteRenderer.color = new Color();
            if (ColorUtility.TryParseHtmlString(colorVal, out theColor))
            { mySpriteRenderer.color = theColor; }
        }
    }
}
