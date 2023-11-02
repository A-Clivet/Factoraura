using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBeltScript : MonoBehaviour
{
    public int price = 5;

    int dir_x;
    int dir_y;

    private void Update()
    {
        Rotation();
    }

    private void Rotation()
    {
        var pos = Quaternion.Euler(0, 0, 0);


        if (transform.rotation.eulerAngles.z == 90 || transform.rotation.eulerAngles.z == -270)
        {
            dir_x = 0;
            dir_y = -1;
        }
        if (transform.rotation.eulerAngles.z == 180 || transform.rotation.eulerAngles.z == -180)
        {
            dir_x = 1;
            dir_y = 0;
        }
        if (transform.rotation.eulerAngles.z == -90 || transform.rotation.eulerAngles.z == 270)
        {
            dir_x = 0;
            dir_y = 1;
        }
        if (transform.rotation.eulerAngles.z == 0 || transform.rotation.eulerAngles.z == 360 || transform.rotation.eulerAngles.z == -360)
        {
            transform.rotation = pos;
            dir_x = -1;
            dir_y = 0;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Aurore Spirit"))
        {
            collision.transform.position = new Vector3(collision.transform.position.x + dir_x, collision.transform.position.y + dir_y, 0);
        }
    }
}
