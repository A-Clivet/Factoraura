using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLoseUI : MonoBehaviour
{
    [SerializeField] private GameObject Win;

    public void WinOn()
    {
        Win.SetActive(true);
    }
    public void WinOff()
    {
        Win.SetActive(false);
    }

}
