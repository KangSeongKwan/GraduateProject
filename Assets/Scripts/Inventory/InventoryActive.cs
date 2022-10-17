using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryActive : MonoBehaviour
{
    public GameObject inventoryPanel;
    bool activeInventory = false;

    // Start is called before the first frame update
    private void Start()
    {
        inventoryPanel.SetActive(activeInventory);

    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            activeInventory = !activeInventory;
            inventoryPanel.SetActive(activeInventory);
        }
    }
}
