using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeStorage : MonoBehaviour
{
    [SerializeField] private List<ShapeData> shapeData;
    [SerializeField] private List<Shape> shapeList;

    public List<ShapeData> ShapeData { get => shapeData; set => shapeData = value; }
    public List<Shape> ShapeList { get => shapeList; set => shapeList = value; }

    // Start is called before the first frame update
    void Start()
    {
/*        foreach (var shape in ShapeList)
        {
            var shapIndex = UnityEngine.Random.Range(0, ShapeData.Count);
            shape.CreateShape(ShapeData[shapIndex]);
        }*/
        ShapeList[0].CreateShape(ShapeData[0]);
    }

/*    public Shape GetCurrentSelectedShape()
    {
        foreach (var shape in ShapeList)
        {
            if (shape.IsOnStartPosition() == false && shape.IsAnyOfShapeSquareActive())
            {
                return shape;
            }
        }
        Debug.LogError("There is no shape selected!");
        return null;
    }

    private void RequestNewShapes()
    {
        foreach (var shape in ShapeList)
        {
            var shapIndex = UnityEngine.Random.Range(0, ShapeData.Count);
            shape.RequestNewShape(ShapeData[shapIndex]);
        }
    }*/
}
