using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
[System.Serializable]
public class ShapeData : ScriptableObject
{
    #region Mod
    /*    public int columns;
        public int rows;
        public bool[,] board;


        public void Clear()
        {
            CreateNewBoard();
            for (var row = 0; row < rows; row++)
            {
                for (var column = 0; column < columns; column++)
                {
                    board[row, column] = false;
                }
            }
        }

        public void CreateNewBoard()
        {
            board = new bool[rows, columns];
        }*/
    #endregion

    #region Mod2
    /*[System.Serializable]
    public class Row
    {
        public bool[] column;
        public int size = 0;

        public Row()
        {

        }

        public Row(int size)
        {
            CreateRow(size);
        }

        public void CreateRow(int size)
        {
            this.size = size;
            column = new bool[size];
            ClearRow();
        }

        public void ClearRow()
        {
            for (int i = 0; i < size; i++)
            {
                column[i] = false;
            }
        }
    }

    public int columns = 0;
    public int rows = 0;
    public Row[,] board;

    public void Clear()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                board[i, j].ClearRow();
            }
        }
    }

    public void CreateNewBoard()
    {
        board = new Row[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                board[i, j] = new Row(columns);
            }
        }
    }*/
    #endregion

    #region Stock
    [System.Serializable]
    public class Row
    {
        public bool[] column;
        public int _size = 0;

        public Row()
        {

        }

        public Row(int size)
        {
            CreateRow(size);
        }

        public void CreateRow(int size)
        {
            _size = size;
            column = new bool[_size];
            ClearRow();
        }

        public void ClearRow()
        {
            for (int i = 0; i < _size; i++)
            {
                column[i] = false;
            }
        }
    }

    public int columns = 0;
    public int rows = 0;
    public Row[] board;
    public void Clear()
    {
        for (var i = 0; i < rows; i++)
        {
            board[i].ClearRow();
        }
    }

    public void CreateNewBoard()
    {
        board = new Row[rows];
        for (var i = 0; i < rows; i++)
        {
            board[i] = new Row(columns);
        }
    }
    #endregion
}
