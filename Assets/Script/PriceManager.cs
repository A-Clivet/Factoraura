using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriceManager : MonoBehaviour
{
    [SerializeField] GameObject Piston;
    [SerializeField] GameObject ConvoyerBelt;
    [SerializeField] GameObject MeltinMachine;
    public static PriceManager Instance;
    
    [NonSerialized] public int prize = 0;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else Destroy(gameObject);
    }
    public int Cost(MoveObject machine)
    {
        if(machine.nametype == "piston")
        {
            prize = Piston.GetComponent<PistonScript>().price;

            return prize;
        }
        if(machine.nametype == "conveyor belt")
        {
            prize = ConvoyerBelt.GetComponent<ConveyorBeltScript>().price;
            return prize;
        }
        if (machine.nametype == "meltin station")
        {
            prize = MeltinMachine.GetComponent<MeltinStation>().price;
            return prize;
        }

        return 0;
    }
}
