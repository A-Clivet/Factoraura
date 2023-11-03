using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CostPrint : MonoBehaviour
{
    [SerializeField] MoveObject machine;
    [SerializeField] TextMeshProUGUI m_TextMeshProUGUI;
    int cost = 0;

    // Start is called before the first frame update
    void Start()
    {
        cost = PriceManager.Instance.Cost(machine);
        m_TextMeshProUGUI.text = "Prix : " + cost;
    }
}
