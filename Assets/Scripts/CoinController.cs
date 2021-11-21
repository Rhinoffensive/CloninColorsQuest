using System.Collections;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    private bool isBlink;
    private float elapsedTime;
    private ColorChanger myColorChanger;
    private SpriteRenderer mySpriteRenderer;
    private Coroutine blinkCoroutine;

    private void Start()
    {
        myColorChanger = GetComponent<ColorChanger>();
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (isBlink)
        {
            mySpriteRenderer.color = new Color(mySpriteRenderer.color.r, mySpriteRenderer.color.g, mySpriteRenderer.color.b,
                Mathf.Lerp(1.0f, 0.0f, Mathf.PingPong(elapsedTime * 2, 1)));
            elapsedTime += Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        ColorChanger otherColorChanger = other.GetComponent<ColorChanger>();
        if (otherColorChanger == null)
            return;

        if (otherColorChanger.blockColorName == myColorChanger.blockColorName)
        {
            print(otherColorChanger.blockColorName);
            Destroy(gameObject);
        }
        else
        {
            if (blinkCoroutine == null)
                blinkCoroutine = StartCoroutine(StartBlink());
        }
    }

    private IEnumerator StartBlink()
    {
        elapsedTime = 0.0f;
        isBlink = true;

        yield return new WaitForSeconds(2.0f);

        isBlink = false;
        blinkCoroutine = null;
    }
}