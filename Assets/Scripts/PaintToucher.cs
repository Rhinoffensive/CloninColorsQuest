using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintToucher : MonoBehaviour
{

    private void Awake()
    {
       // GetComponent<ColorChanger>().gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Block")
        {

            other.GetComponent<ColorChanger>().blockColorName = GetComponentInParent<ColorChanger>().blockColorName;
            other.GetComponent<SpriteRenderer>().color = GetComponentInParent<SpriteRenderer>().color;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
