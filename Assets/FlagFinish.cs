using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FlagFinish : MonoBehaviour
{
    // Start is called before the first frame update
    public delegate void CapturedFlag();
    public event CapturedFlag captureFlagEvent;

    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Block" && other.GetComponent<ColorChanger>().blockColorName == GetComponent<ColorChanger>().blockColorName)
        {
            if(captureFlagEvent !=null)
                captureFlagEvent();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
