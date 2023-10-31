using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BuyMachine : MonoBehaviour
{
    [SerializeField] GameObject machine;

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
        if(context.performed && select)
        {
            Instantiate(machine, m_pos, Quaternion.identity);
            select = false;
            //machine.GetComponent<>
            // faire un script a part qui recupere les valeurs de chaque machine, et recuperer ces valeur sur ce script manager
        }
    }
}
