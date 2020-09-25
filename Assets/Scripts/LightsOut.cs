using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOut : MonoBehaviour
{
    // Start is called before the first frame update

    public List<List<bool>> Grid = new List<List<bool>>();
    public int GridSize;
    public GameObject GridRowPrefab;
    public GameObject Tile;
    public GameObject content;

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
            List<bool> gridRow = new List<bool>();
            for (int j = 0; j < GridSize; j++)
            {
                bool test = true;
                gridRow.Add(test);
                GameObject tile = Instantiate(Tile, newRowContent);
            }
            Grid.Add(gridRow);
        }
    }
}
