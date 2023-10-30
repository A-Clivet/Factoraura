using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour
{
    bool _isPressed;
    Vector2 _direction;

    float _cameraSpeed = 0.08f;

    [SerializeField] GameObject _cameraGameObject;

    private void Update()
    {
        if (_isPressed)
        {
            MovingCamera();
        }
    }

    public void DetectPressureOfArrowKey(bool pressed, Vector2 direction)
    {
        _isPressed = pressed;
        _direction = direction;
    }

    public void MovingCamera()
    {
        _cameraGameObject.transform.position += new Vector3(_direction.x * _cameraSpeed, _direction.y * _cameraSpeed, 0);
    }
}