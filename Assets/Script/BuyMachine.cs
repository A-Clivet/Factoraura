using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.InputSystem;

public class BuyMachine : MonoBehaviour
{
    [SerializeField] GameObject Piston;
    [SerializeField] GameObject ConvoyerBelt;
    [SerializeField] GameObject MeltinStation;


    [SerializeField] GameObject machine;
    [SerializeField] Money money;

    Vector3 m_pos;

    bool select = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        m_pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        m_pos.z = machine.transform.localPosition.z;

    }

    public void Create() 
    {
        select = true;
    }

    public void Spawn(InputAction.CallbackContext context)
    {
        if(context.performed && select && money.Budget - PriceManager.Instance.Cost(machine) >= 0)
        {
            Instantiate(machine, m_pos, Quaternion.identity);
            select = false;
            money.Budget -= PriceManager.Instance.Cost(machine);
        }    
    }
}
