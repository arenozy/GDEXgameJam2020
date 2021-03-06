﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideMaster : MonoBehaviour
{
    [SerializeField] GameObject tileContainer;
    [SerializeField] GameObject tileChecker;

    public bool[] isWin = new bool[16];
    // Start is called before the first frame update
    public void ResetGame()
    {
        foreach(Transform tile in tileContainer.transform)
        {
            tile.position = tile.gameObject.GetComponent<SlidePuzzle>().origPos;
        }
    }

    // Update is called once per frame
    public void UpdatePos(GameObject tile)
    {
        foreach(Transform check in tileChecker.transform)
        {
            if(check.name == tile.name)
            {
                if(check.position == tile.transform.position)
                {
                    isWin[check.GetSiblingIndex()] = true;
                }
                else
                {
                    isWin[check.GetSiblingIndex()] = false;
                }
            }
        }
        CheckWin();
    }

    public void CheckWin()
    {
        bool weWon = true;
        for(int i = 0; i < isWin.Length-1; i++)
        {
            if (!isWin[i])
            {
                weWon = false;
            }
        }
        if (weWon)
        {
            gameObject.transform.parent.gameObject.SetActive(false);
        }
    }

    public void YouWin()
    {
        gameObject.transform.parent.gameObject.SetActive(false);
    }
}
