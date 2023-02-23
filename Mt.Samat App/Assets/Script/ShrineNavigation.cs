using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ShrineNavigation : MonoBehaviour
{
    [SerializeField] private GameObject[] shrinePanels;
    [SerializeField] private Button[] shrineButtons;

    
    public void navigationShrineClick(GameObject activeShrinePanel, string title)
    {
        foreach (var item in shrinePanels)
        {
            item.SetActive(false);
        }

        if (title == "Cannon")
        {
            Debug.Log("This is Cannon");
            //activeShrinePanel.SetActive(true);
        }
        else if (title == "Museum")
        {
            Debug.Log("This is Cannon");
        }
    }
    
}
