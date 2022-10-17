using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item_array : MonoBehaviour
{
    public List<Item> items_ar;
    private void Update()
    {
        items_ar = GameObject.Find("Inventory").GetComponent<Inventory>().items;
    }
}
