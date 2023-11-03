using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Trash : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] Money money;
    [NonSerialized] public GameObject doSale;
    public static Trash Instance;

    bool canSale = false;


    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else Destroy(gameObject);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        canSale = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        canSale = false;
        doSale = null;
    }

    public void Sale()
    {
        if (canSale)
        {
            money.Budget += PriceManager.Instance.Cost(doSale);
            Debug.Log("vente");
            Destroy(doSale);
        }
    }
}