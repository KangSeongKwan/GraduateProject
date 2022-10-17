using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContact : MonoBehaviour
{

    public bool delete_on = false;
    public bool swap_on = false;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "event")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Delete")
        {
            Destroy(other.gameObject);
            GameObject.Find("CanvasInventory").GetComponent<InventoryActive>().activeInventory = true;
            delete_on = true;
            GameObject.Find("player").GetComponent<Click_Move>().click = false;
        }
        if (other.gameObject.tag == "Swap")
        {
            Destroy(other.gameObject);
            GameObject.Find("CanvasInventory").GetComponent<InventoryActive>().activeInventory = true;
            swap_on = true;
            GameObject.Find("player").GetComponent<Click_Move>().click = false;
        }
    }
}