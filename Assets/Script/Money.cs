using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Money : MonoBehaviour
{
    public int Budget = 100;
    [SerializeField] TextMeshProUGUI m_TextMeshProUGUI;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_TextMeshProUGUI.text = "Pièce : " + Budget;
    }
}
