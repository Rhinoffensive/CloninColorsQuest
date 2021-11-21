using System.Collections;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    private SpriteRenderer coinSpriteRenderer;
    private Animator animator;
    private void Start()
    {
        coinSpriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            Color coinColor = coinSpriteRenderer.color;
            Color blockColor = collision.gameObject.GetComponent<SpriteRenderer>().color;
            if (!blockColor.Equals(coinColor))
            {
                StartCoroutine(ChangeAlpha());
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }

    private IEnumerator ChangeAlpha()
    {
        animator.Play("alphaChanging");
        yield return new WaitForSeconds(1);
        animator.Play("Idle");
    }
}
