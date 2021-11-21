using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintToucher : MonoBehaviour
{
  
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
