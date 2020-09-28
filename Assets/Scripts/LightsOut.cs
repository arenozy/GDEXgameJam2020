using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightsOut : MonoBehaviour
{
    // Start is called before the first frame update

    public List<List<GameObject>> Grid = new List<List<GameObject>>();
    public int GridSize;
    public GameObject GridRowPrefab;
    public GameObject Tile;
    public GameObject content;

    [SerializeField] Color colorLit;
    [SerializeField] Color colorDark;


    void Start()
    {
        GenerateGrid();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach(Transform child in content.transform)
            {
                Destroy(child.gameObject);
            }
            GenerateGrid();
        }
    }
    public void GenerateGrid()
    {
        for (int i = 0; i < GridSize; i++)
        {
            GameObject newRow = Instantiate(GridRowPrefab, content.transform);
            Transform newRowContent = newRow.transform.GetChild(0).GetChild(0);
            Debug.Log(newRowContent.name);
            List<GameObject> gridRow = new List<GameObject>();
            for (int j = 0; j < GridSize; j++)
            {
                GameObject tile = Instantiate(Tile, newRowContent);
                tile.GetComponent<LOtile>().SetPos(i, j);
                gridRow.Add(tile);
            }
            Grid.Add(gridRow);
        }
    }

    public void FlipLights(int colPos, int rowPos)
    {
        List<GameObject> rowList = Grid[colPos];
        GameObject selectedTile = rowList[rowPos];
        Flip(selectedTile);

        // Get E tile
        if(rowPos < rowList.Count - 1)
        {
            selectedTile = rowList[rowPos+1];
            Flip(selectedTile);
        }

        // Get W tile
        if (rowPos > 0)
        {
            selectedTile = rowList[rowPos - 1];
            Flip(selectedTile);
        }

        // Get N tile
        if (colPos > 0)
        {
            rowList = Grid[colPos-1];
            selectedTile = rowList[rowPos];
            Flip(selectedTile);
        }

        // Get S tile
        if (colPos < Grid.Count-1)
        {
            rowList = Grid[colPos + 1];
            selectedTile = rowList[rowPos];
            Flip(selectedTile);
        }

        bool win = true;
        foreach(List<GameObject> row in Grid)
        {
            foreach(GameObject tile in row)
            {
                if (tile.GetComponent<Image>().color == colorDark)
                {
                    win = false;
                }
            }
        }
        if(win)
        {
            Debug.Log("Yay");
        }
    }

    public void Flip(GameObject tile)
    {
        Image tileImage = tile.GetComponent<Image>();

        if(tileImage.color == colorLit)
        {
            tileImage.color = colorDark;
        }
        else
        {
            tileImage.color = colorLit;
        }
    }
}
