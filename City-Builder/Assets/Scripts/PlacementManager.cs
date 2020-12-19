﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementManager : MonoBehaviour
{
    public GameObject BuildingPrefab;
    [SerializeField] Transform _ground;


    public void CreateBuilding(Vector3 positon, GridStructure gridStructure)
    {

        GameObject newStructure = Instantiate(BuildingPrefab, _ground.position + positon, Quaternion.identity);
        gridStructure.PlaceObjectOnGrid(positon, newStructure);
    }
}
