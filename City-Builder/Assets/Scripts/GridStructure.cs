using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridStructure
{
    private int _cellSize;

    Cell[,] _grid;
    private int _width, _height;

    public GridStructure(int cellSize, int width, int height)
    {
        _cellSize = cellSize;
        _height = height;
        _width = width;
        _grid = new Cell[_width, _height];
    }
    public Vector3 CalculateGridStructure(Vector3 inputPosition)
    {
        int x = Mathf.FloorToInt(inputPosition.x / _cellSize);
        int z = Mathf.FloorToInt(inputPosition.z / _cellSize);

        return new Vector3(x * _cellSize, 0, z * _cellSize);
    }

}
