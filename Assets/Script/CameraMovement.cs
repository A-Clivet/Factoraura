using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMovement : MonoBehaviour
{
    CameraHandler _cameraHandler;

    private void Awake()
    {
        _cameraHandler = GetComponent<CameraHandler>();
    }

    public void ZQSD(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            _cameraHandler.DetectPressureOfArrowKey(true, context.ReadValue<Vector2>());
        }
        else if (context.canceled)
        {
            _cameraHandler.DetectPressureOfArrowKey(false, context.ReadValue<Vector2>());
        }
    }
}
