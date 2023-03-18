using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ShapeData), false)]
[CanEditMultipleObjects]
[System.Serializable]
public class ShapeDataDrawer : Editor
{
    #region Mod
    /*
     private ShapeData shapeDataInstance => target as ShapeData;

     public override void OnInspectorGUI()
     {
         serializedObject.Update();
         ClearBoardButton();
         EditorGUILayout.Space();
         DrawColumnsInputFields();
         EditorGUILayout.Space();
         if (shapeDataInstance.board != null && shapeDataInstance.columns > 0 && shapeDataInstance.rows > 0)
         {
             DrawBoardTable();
         }

         serializedObject.ApplyModifiedProperties();
         if (GUI.changed)
         {
             EditorUtility.SetDirty(shapeDataInstance);
         }
     }

     private void ClearBoardButton()
     {
         if (shapeDataInstance.board != null && GUILayout.Button("Clear Board"))
         {
             shapeDataInstance.Clear();
         }
     }

     private void DrawColumnsInputFields()
     {
         var columsTemp = shapeDataInstance.columns;
         var rowsTemp = shapeDataInstance.rows;

         shapeDataInstance.columns = EditorGUILayout.IntField("Columns", shapeDataInstance.columns);
         shapeDataInstance.rows = EditorGUILayout.IntField("Rows", shapeDataInstance.rows);
         if ((shapeDataInstance.columns != columsTemp || shapeDataInstance.rows != rowsTemp)
             && shapeDataInstance.columns > 0 && shapeDataInstance.rows > 0)
         {
             shapeDataInstance.CreateNewBoard();
         }
     }

     private void DrawBoardTable()
     {
         var tableStyle = new GUIStyle("box");
         tableStyle.padding = new RectOffset(10, 10, 10, 10);
         tableStyle.margin.left = 30;

         var headerColumnStyle = new GUIStyle();
         headerColumnStyle.fixedHeight = 65;
         headerColumnStyle.alignment = TextAnchor.MiddleCenter;

         var rowStyle = new GUIStyle();
         rowStyle.fixedHeight = 25;
         rowStyle.alignment = TextAnchor.MiddleCenter;

         var dataFieldStyle = new GUIStyle(EditorStyles.miniButtonMid);
         dataFieldStyle.normal.background = Texture2D.grayTexture;
         dataFieldStyle.onNormal.background = Texture2D.whiteTexture;

         for (var row = 0; row < shapeDataInstance.rows; row++)
         {

             EditorGUILayout.BeginHorizontal(rowStyle, GUILayout.Height(headerColumnStyle.fixedHeight));
             for (var column = 0; column < shapeDataInstance.columns; column++)
             {
                 var data = EditorGUILayout.Toggle(shapeDataInstance.board[row,column], dataFieldStyle, GUILayout.Width(30), GUILayout.Height(20));
                 shapeDataInstance.board[row, column] = data;
             }
             EditorGUILayout.EndHorizontal();
         }
     }*/
    #endregion

    #region Stock
    private ShapeData shapeDataInstance => target as ShapeData;

    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        ClearBoardButton();
        EditorGUILayout.Space();
        DrawColumnsInputFields();
        EditorGUILayout.Space();
        if (shapeDataInstance.board != null && shapeDataInstance.columns > 0 && shapeDataInstance.rows > 0)
        {
            DrawBoardTable();
        }

        serializedObject.ApplyModifiedProperties();
        if (GUI.changed)
        {
            EditorUtility.SetDirty(shapeDataInstance);
        }
    }

    private void ClearBoardButton()
    {
        if(GUILayout.Button("Clear Board"))
        {
            shapeDataInstance.Clear();
        }
    }

    private void DrawColumnsInputFields()
    {
        var columsTemp = shapeDataInstance.columns;
        var rowsTemp = shapeDataInstance.rows;
        shapeDataInstance.columns = EditorGUILayout.IntField("Columns", shapeDataInstance.columns);
        shapeDataInstance.rows = EditorGUILayout.IntField("Rows", shapeDataInstance.rows);
        if ((shapeDataInstance.columns != columsTemp || shapeDataInstance.rows != rowsTemp)
            && shapeDataInstance.columns > 0 && shapeDataInstance.rows > 0)
        {
            shapeDataInstance.CreateNewBoard();
        }
    }

    private void DrawBoardTable()
    {
        var tableStyle = new GUIStyle("box");
        tableStyle.padding = new RectOffset(10, 10, 10, 10);
        tableStyle.margin.left = 30;

        var headerColumnStyle = new GUIStyle();
        headerColumnStyle.fixedHeight = 65;
        headerColumnStyle.alignment = TextAnchor.MiddleCenter;

        var rowStyle = new GUIStyle();
        rowStyle.fixedHeight = 25;
        rowStyle.alignment = TextAnchor.MiddleCenter;

        var dataFieldStyle = new GUIStyle(EditorStyles.miniButtonMid);
        dataFieldStyle.normal.background = Texture2D.grayTexture;
        dataFieldStyle.onNormal.background = Texture2D.whiteTexture;

        for (var row = 0; row < shapeDataInstance.rows; row++)
        {

            EditorGUILayout.BeginHorizontal(rowStyle, GUILayout.Height(headerColumnStyle.fixedHeight));
            for (var column = 0; column < shapeDataInstance.columns; column++)
            {
                var data = EditorGUILayout.Toggle(shapeDataInstance.board[row].column[column], dataFieldStyle, GUILayout.Width(30), GUILayout.Height(20));
                shapeDataInstance.board[row].column[column] = data;
            }
            EditorGUILayout.EndHorizontal();
        }
    }
    #endregion
}