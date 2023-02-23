using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{
    [SerializeField] private GameObject[] panels;

    public void navigationBarClick(GameObject activePanel)
    {
        foreach (var item in panels)
        {
            item.SetActive(false);
        }
        activePanel.SetActive(true);
    }
}
