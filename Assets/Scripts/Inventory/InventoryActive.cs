using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryActive : MonoBehaviour
{
    public GameObject inventoryPanel;
    public bool activeInventory = false;

    // Start is called before the first frame update

    // Update is called once per frame
    private void Update()
    {
        inventoryPanel.SetActive(activeInventory);
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (!GameObject.Find("player").GetComponent<EnemyContact>().delete_on && !GameObject.Find("player").GetComponent<EnemyContact>().swap_on)
                activeInventory = !activeInventory;
        }

    }
}
