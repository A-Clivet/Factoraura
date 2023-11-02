using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trash : MonoBehaviour
{
    [SerializeField] Money money;
    GameObject doSale;
    bool canSale = false;

    public void Sale()
    {
        if (canSale)
        {
            money.Budget += PriceManager.Instance.Cost(doSale);
            Destroy(doSale);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        canSale = true;
        doSale = collision.gameObject;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canSale = false;
        doSale = null;
    }
}
