using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPos : MonoBehaviour
{
    public bool position = true;
    public InputActionReference action;
    public Transform room;
    public Transform outside;


    void Start()
    {
 
        action.action.Enable();
    }

    private void Update()
    {
        action.action.performed += Change;
    }
    private void Change(InputAction.CallbackContext context)
    {
        if (position == false)
        {
            transform.position = room.position;
            position = true;
        }
        else { 
        transform.position = outside.position;
        position = false;
    }
    }
}