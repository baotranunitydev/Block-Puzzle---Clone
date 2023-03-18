using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    [SerializeField] GameObject squareImage;
    [SerializeField] Vector2 offset;

    [SerializeField] ShapeData currentShapeData;
    [SerializeField] int totalSquareNumber;

    [SerializeField] List<GameObject> listSquare = new List<GameObject>();

    public ShapeData CurrentShapeData { get => currentShapeData; set => currentShapeData = value; }
    public int TotalSquareNumber { get => totalSquareNumber; set => totalSquareNumber = value; }


    private void Start()
    {

    }

    public void CreateShape(ShapeData shapeData)
    {
        CurrentShapeData = shapeData;
        TotalSquareNumber = GetNumberOfShape(shapeData);
        while (listSquare.Count <= TotalSquareNumber)
        {
            listSquare.Add(Instantiate(squareImage, transform) as GameObject);
        }
        foreach (var shape in listSquare)
        {
            shape.gameObject.transform.position = Vector3.zero;
            shape.gameObject.SetActive(false);
        }
        var squareRect = squareImage.GetComponent<RectTransform>();
        var moveDistance = new Vector2(squareRect.rect.width * squareRect.localScale.x,
            squareRect.rect.height * squareRect.localScale.y);
        int currentIndexInlist = 0;
        for (var row = 0; row < shapeData.rows; row++)
        {
            for (var column = 0; column < shapeData.columns; column++)
            {
                if (shapeData.board[row].column[column])
                {
                    listSquare[currentIndexInlist].SetActive(true);
                    listSquare[currentIndexInlist].GetComponent<RectTransform>().localPosition =
                    new Vector2(GetXPositionForShape(shapeData, column, moveDistance), GetYPositionForShape(shapeData, row, moveDistance));
                    currentIndexInlist++;
                }
            }
        }
    }


    private float GetXPositionForShape(ShapeData shapeData, int column, Vector2 moveDistance)
    {
        float shiftOnX = 0f;
        if (shapeData.columns > 1)
        {
            float startXPos;
            if (shapeData.columns % 2 != 0)
                startXPos = (shapeData.columns / 2) * moveDistance.x * -1;
            else
                startXPos = ((shapeData.columns / 2) - 1) * moveDistance.x * -1 - moveDistance.x / 2;
            shiftOnX = startXPos + column * moveDistance.x;

        }
        return shiftOnX;
    }

    private float GetYPositionForShape(ShapeData shapeData, int row, Vector2 moveDistance)
    {
        float shiftOnY = 0f;
        if (shapeData.rows > 1)
        {
            float startYPos;
            if (shapeData.rows % 2 != 0)
                startYPos = (shapeData.rows / 2) * moveDistance.y;
            else
                startYPos = ((shapeData.rows / 2) - 1) * moveDistance.y + moveDistance.y / 2;
            shiftOnY = startYPos - row * moveDistance.y;
        }
        return shiftOnY;
    }

    private int GetNumberOfShape(ShapeData shapeData)
    {
        int number = 0;
        foreach (var rowData in shapeData.board)
        {
            foreach (var active in rowData.column)
            {
                if (active)
                {
                    number++;
                }
            }
        }
        return number;
    }
}
