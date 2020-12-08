using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public InputManager InputManager;
    public PlacementManager PlacementManager;
    private GridStructure Grid;

    private int _cellSize = 3;

    private void Start()
    {
        Grid = new GridStructure(3);
        InputManager.AddListenerOnPointerDownEvent(HandleInput);
    }

    private void HandleInput(Vector3 pos)
    {
        PlacementManager.CreateBuilding(Grid.CalculateGridStructure(pos));
    }
}
