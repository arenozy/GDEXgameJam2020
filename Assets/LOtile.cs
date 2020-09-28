using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOtile : MonoBehaviour
{
    public bool isLit;
    public int colPos;
    public int rowPos;

    public void FlipColor(GameObject tile)
    {
        FindObjectOfType<LightsOut>().FlipLights(colPos, rowPos);
    }

    public void SetPos(int col, int row)
    {
        colPos = col;
        rowPos = row;
    }
}
