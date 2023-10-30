using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Choose : MonoBehaviour
{

    public void Grabed(InputAction.CallbackContext context)
    {
        if (context.performed || context.canceled)
        {
            var Hit = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition), 5000, LayerMask.GetMask("grabbable"));
            if (Hit)
            {
                Hit.collider.GetComponent<MoveObject>().Interact();
            }
        }
    }
}
