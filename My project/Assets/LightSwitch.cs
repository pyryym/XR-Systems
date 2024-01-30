using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public Light light;
    public InputActionReference action;

    void Start()
    {
        action.action.Enable();
        light = GetComponent<Light>();
        action.action.performed += Light;
    }

    private void Light(InputAction.CallbackContext context)
    {
        light.color = Color.red;
    }
}
