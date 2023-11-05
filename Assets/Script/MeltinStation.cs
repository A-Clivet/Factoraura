using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeltinStation : MonoBehaviour
{
    public int price = 20;
    int onWait = 0;
    GameObject target1;
    GameObject target2;


    // Update is called once per frame
    void Update()
    {

        if (onWait == 2)
        {
            MeltDown();
        }
    }

    void MeltDown()
    {
        // Instantier le nouvel objet puis détruire target 1 et target 2
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Aurore Spirit"))
        {
            if (target1 == null)
            {
                target1 = collision.gameObject;
            }
            else if (target1 != null)
            {
                target2 = collision.gameObject;
            }
            onWait += 1;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Aurore Spirit"))
        {
            if (target2 != null)
            {
                target2 = null;
            }
            else if (target1 != null)
            {
                target1 = null;
            }
            onWait -= 1;
        }
    }
}
