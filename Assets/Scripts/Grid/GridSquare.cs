using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSquare : MonoBehaviour
{

    [SerializeField] GameObject squares;
    [SerializeField] int columns;
    [SerializeField] int rows;
    [SerializeField] Vector2 offset;

    public GameObject[,] squaresArray;
    [SerializeField] List<GameObject> listSquares = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        CreateGrid();
    }

    private void CreateGrid()
    {
        SpawnGridSquares();
    }

    private void SpawnGridSquares()
    {
        squaresArray = new GameObject[columns,rows];
        float sizeX = squares.GetComponent<RectTransform>().sizeDelta.x;
        float sizeY = squares.GetComponent<RectTransform>().sizeDelta.y;
        int squareIndex = 0;
        for(var row = 0; row < rows; ++row)
        {
            for(var column = 0; column < columns; ++column)
            {
                var spawn = Instantiate(squares) as GameObject;
                spawn.name = string.Format("({0},{1})", column, row);
                spawn.transform.SetParent(this.transform);
                listSquares.Add(spawn);
                listSquares[squareIndex].transform.localScale = new Vector3(1, 1,1);
                listSquares[squareIndex].GetComponent<RectTransform>().anchoredPosition = new Vector3((sizeX + offset.x)*column, (sizeY + offset.y)*row,0);
                squaresArray[column, row] = spawn;
                squareIndex++;
            }
        }
    }
}
