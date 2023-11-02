using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField] GameObject Trash;
    bool IsGrabed = false;
    float pos_z;

    private void Start()
    {
        pos_z = transform.position.z;
    }
    public void Interact()
    {
        IsGrabed = !IsGrabed; // inverse la valeur de isgrabed

        if (!IsGrabed) // quandje lâche l'object
        {
            // nom de la fonction que j'appelle
            // Trash.Sale();
        }
    }

    private void Update()
    {
        if (IsGrabed)
        {
            // Move les objets
            Vector3 m_pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            m_pos.z = pos_z;
            transform.position = m_pos;

        }
    }
}
