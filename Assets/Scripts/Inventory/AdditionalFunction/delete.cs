using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delete : MonoBehaviour
{

    public void del(int count, List<Item> item_Item, List<string> item_string)
    {
        del_list(count, item_Item);
        del_string(count, item_string);
    }
    public void del_list(int count, List<Item> item_)
    {
        item_.RemoveAt(count);
        GameObject.Find("Inventory").GetComponent<Inventory>().FreshSlot();
    }
    public void del_string(int count, List<string> item_)
    {
        item_.RemoveAt(count);
    }
}
