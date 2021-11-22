// GameDev.tv ChallengeClub.Got questionsor wantto shareyour niftysolution?
// Head over to - http://community.gamedev.tv

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
    [SerializeField] private BlockMovement[] allPlayerBlocks;

    [SerializeField] Text youWonTxt;
    [SerializeField] Text youLoseTxt;

 
    void Start()
    {
        AllPlayerBlocksArrayUpdate();
        FindObjectOfType<FlagFinish>().captureFlagEvent += Won;
    }

    void Update()
    {
        BlockSelection();
    }

    void Won()
    {
        FindObjectOfType<FlagFinish>().captureFlagEvent -= Won;
        DisableBlocks();
        youWonTxt.gameObject.SetActive(true);
    }


    void Lose()
    {
        DisableBlocks();
        youLoseTxt.gameObject.SetActive(true);
    }
    private void BlockSelection()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ActiveBlockPlusOne();
        }
        if (Input.GetMouseButtonDown(1))
        {
            ActiveBlockMinusOne();
        }
    }

    public void AllPlayerBlocksArrayUpdate()
    {
        allPlayerBlocks = FindObjectsOfType<BlockMovement>();
    }

    public void DestroyedBlockUpdate()
    {
        ActiveBlockPlusOne();
    }

    private void ActiveBlockPlusOne()
    {
        AllPlayerBlocksArrayUpdate();


        for (int i = 0; i < allPlayerBlocks.Length; i++)
        {
            if (allPlayerBlocks[i].GetComponent<BlockMovement>().isActiveBool)
            {
                allPlayerBlocks[i].GetComponent<BlockMovement>().isActiveBool = false;

                if (i < allPlayerBlocks.Length - 1)
                {
                    allPlayerBlocks[i + 1].GetComponent<BlockMovement>().isActiveBool = true;
                    break;

                }
                else
                {
                    allPlayerBlocks[0].GetComponent<BlockMovement>().isActiveBool = true;
                    break;
                }
            }
        }
    }

    
    private void ActiveBlockMinusOne()
    {
        AllPlayerBlocksArrayUpdate();

        for (int i = 0; i < allPlayerBlocks.Length; i++)
        {
            if (allPlayerBlocks[i].GetComponent<BlockMovement>().isActiveBool)
            {
                allPlayerBlocks[i].GetComponent<BlockMovement>().isActiveBool = false;

                if (i >= 1)
                {
                    allPlayerBlocks[i - 1].GetComponent<BlockMovement>().isActiveBool = true;
                    break;

                }
                else
                {
                    allPlayerBlocks[allPlayerBlocks.Length - 1].GetComponent<BlockMovement>().isActiveBool = true;
                    break;
                }
            }
        }
    }


    void DisableBlocks()
    {
        AllPlayerBlocksArrayUpdate();
        for(int i = 0; i < allPlayerBlocks.Length; i++)
        {
            allPlayerBlocks[i].GetComponent<BlockMovement>().isActiveBool = false;
        }
    }
}
