using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GridStructure
{
    private int _cellSize;

    private Cell[,] _grid;
    private int _width, _height;

    public GridStructure(int cellSize, int width, int height)
    {
        _cellSize = cellSize;
        _height = height;
        _width = width;
        _grid = new Cell[_width, _height];

        for (int row = 0; row < _grid.GetLength(0); row++)
        {
            for (int col = 0; col < _grid.GetLength(1); col++)
            {
                _grid[row, col] = new Cell();
            }
        }
    }
    public Vector3 CalculateGridStructure(Vector3 inputPosition)
    {
        int x = Mathf.FloorToInt(inputPosition.x / _cellSize);
        int z = Mathf.FloorToInt(inputPosition.z / _cellSize);

        return new Vector3(x * _cellSize, 0, z * _cellSize);
    }


    private Vector2Int CalculateGridIndex(Vector3 gridPosition)
    {
        return new Vector2Int((int) (gridPosition.x / _cellSize), (int)(gridPosition.z / _cellSize));
    }

    public bool IsCellTaken(Vector3 gridPosition)
    {
        Vector2Int cellIndex = CalculateGridIndex(gridPosition);

        if (IsIndexValid(cellIndex))
            return _grid[cellIndex.y, cellIndex.x].IsTaken;

        throw new IndexOutOfRangeException("Index out of Range");
    }

    public void PlaceObjectOnGrid(Vector3 position, GameObject objectModel)
    {
        Vector2Int cellIndex = CalculateGridIndex(position);
        if (IsIndexValid(cellIndex))
            _grid[cellIndex.y, cellIndex.x].ConstructCell(objectModel);
    }

    private bool IsIndexValid(Vector2Int cellIndex)
    {
        return cellIndex.x >= 0 && cellIndex.x < _grid.GetLength(1) && cellIndex.y >= 0 && cellIndex.y < _grid.GetLength(0);
    }

}
