using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideMaster : MonoBehaviour
{
    [SerializeField] GameObject tileContainer;
    [SerializeField] GameObject tileChecker;

    public bool[] isWin = new bool[16];
    // Start is called before the first frame update
    void Start()
    {
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
            Debug.Log("yay " + isWin.Length);
        }
    }
}
