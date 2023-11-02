using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundingBox : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < - 1.75)
        {
            transform.position = new Vector3(-1.75f, transform.position.y, transform.position.z);
        }

        if(transform.position.x > 1.5)
        {
            transform.position = new Vector3(1.5f, transform.position.y, transform.position.z);
        }

        if(transform.position.y < - 2)
        {
            transform.position = new Vector3(transform.position.x, - 2, transform.position.z);
        }

        if(transform.position.y > 2.5)
        {
            transform.position = new Vector3(transform.position.x, 2.5f, transform.position.z);
        }
    }
}
