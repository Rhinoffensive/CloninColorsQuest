using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintToucher : MonoBehaviour
{
    private GameObject parrent;
    private PresetColor gem_color;
    private SpriteRenderer getSpriteRenderer;

    private void Awake()
    {


        {
            var sr_p = parrent.GetComponentInParent<SpriteRenderer>();
            var parrent_color = sr_p.color;
            GetComponent<SpriteRenderer>().color = parrent_color;
            var block_color = GetComponent<ColorChanger>().color;
            var colEnum = GetComponent<SpriteRenderer>();

            Color theColor;
            if (ColorUtility.TryParseHtmlString(block_color.ToString(), out theColor))
            {
                sr_p.color = theColor;
                // = System.Enum.GetName(typeof(PresetColor), block_color);
            }




        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Block")
        {
            other.GetComponent<ColorChanger>().blockColorName = GetComponent<ColorChanger>().blockColorName;
            other.GetComponent<SpriteRenderer>().color = GetComponent<SpriteRenderer>().color;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
