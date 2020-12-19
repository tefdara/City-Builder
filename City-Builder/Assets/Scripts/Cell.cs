using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell 
{
    private GameObject _structureModel = null;

    private bool _isTaken = false;

    public bool IsTaken { get => _isTaken;}


    public void ConstructCell(GameObject structureModel)
    {
        _structureModel = structureModel;

        if(structureModel != null)
        _isTaken = true;
    }
}
