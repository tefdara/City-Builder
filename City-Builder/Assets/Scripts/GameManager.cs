using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public InputManager InputManager;
    public PlacementManager PlacementManager;
    
    private GridStructure GridStructure;

    private int _cellSize = 3;
    public int _width, _height;


    private void Start()
    {
        GridStructure = new GridStructure(_cellSize, _width, _height);
        InputManager.AddListenerOnPointerDownEvent(HandleInput);
    }

    private void HandleInput(Vector3 pos)
    {
        Vector3 gridPosition = GridStructure.CalculateGridStructure(pos);

        if(!GridStructure.IsCellTaken(gridPosition))
        PlacementManager.CreateBuilding(gridPosition, GridStructure);
    }
}
