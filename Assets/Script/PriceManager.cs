using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriceManager : MonoBehaviour
{
    [SerializeField] GameObject Piston;
    [SerializeField] GameObject ConvoyerBelt;
    [SerializeField] GameObject MeltinStation;
    public static PriceManager Instance;
    
    [NonSerialized] public int prize = 0;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else Destroy(gameObject);
    }
    public int Cost(GameObject machine)
    {
        if(machine == Piston)
        {
            prize = Piston.GetComponent<PistonScript>().price;

            return prize;
        }
        if(machine == ConvoyerBelt)
        {
            prize = ConvoyerBelt.GetComponent<ConveyorBeltScript>().price;
            return prize;
        }

        return 0;
    }
}
