using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlSelection : MonoBehaviour
{
    [SerializeField] GameObject LS; // Level Selection
    [SerializeField] GameObject MM; // MainMenu
    public void LevelSelection()
    {
        transform.parent.gameObject.SetActive(false);
        LS.SetActive(true);
    }

    public void MainMenu()
    {
        transform.parent.gameObject.SetActive(false);
        MM.SetActive(true);
    }
}
