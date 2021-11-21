// GameDev.tv ChallengeClub.Got questionsor wantto shareyour niftysolution?
// Head over to - http://community.gamedev.tv


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewBlock : MonoBehaviour
{
    [SerializeField] GameObject blockPrefab;
    [SerializeField] Transform spawnPosition;

    public void SpawnBlock()
    {
        System.Array values = System.Enum.GetValues(typeof(PresetColor));
        int selection = Random.Range(0, values.Length);
        PresetColor color = (PresetColor)values.GetValue(selection);

        Color theColor;
        if (ColorUtility.TryParseHtmlString(color.ToString(), out theColor))
        {

            blockPrefab.GetComponent<SpriteRenderer>().color = theColor;
        }
        Instantiate(blockPrefab, spawnPosition.position, Quaternion.identity);
    }
}
