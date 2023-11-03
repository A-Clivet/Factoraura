using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Void : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("enter");
        Destroy(collision.gameObject);
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("stay");
        Destroy(collision.gameObject);
    }
}
