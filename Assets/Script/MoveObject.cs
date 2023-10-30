using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    bool IsGrabed = false;
    public void Interact()
    {
        IsGrabed = !IsGrabed;

        if (!IsGrabed)
        {

        }
    }

    private void Update()
    {
        if (IsGrabed)
        {
            // Move les Blobs
            Vector3 m_pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            m_pos.z = 0;
            transform.position = m_pos;

        }
    }

}
