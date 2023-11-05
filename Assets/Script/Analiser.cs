using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Analiser : MonoBehaviour
{
    [SerializeField] GameObject required;
    [SerializeField] GameObject VictoryUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(required.tag == collision.gameObject.tag)
        {
            VictoryUI.SetActive(true);
        }
    }
}
