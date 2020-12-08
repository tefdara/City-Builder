using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputManager : MonoBehaviour
{
    private Action<Vector3> OnPointerDownHandler;
    public LayerMask MouseInputMask;


    private void Update()
    {
        GetInput();
    }
    public void GetInput()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hitInfo;

            if(Physics.Raycast(ray.origin, ray.direction, out hitInfo, Mathf.Infinity, MouseInputMask))
            {
                Vector3 point = hitInfo.point - transform.position;
                Debug.Log(point);
                OnPointerDownHandler?.Invoke(point);
            }

        }
    }

    public void AddListenerOnPointerDownEvent(Action<Vector3> listener)
    {
        OnPointerDownHandler += listener;
    }
    public void RemoveListenerOnPointerDownEvent(Action<Vector3> listener)
    {
        OnPointerDownHandler -= listener;
    }


}
