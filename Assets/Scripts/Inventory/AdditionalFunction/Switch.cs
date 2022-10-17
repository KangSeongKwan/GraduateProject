using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Switch : MonoBehaviour
{
    public int Cnum1 = -1;
    public int Cnum2 = -1;
    public int ChangeCnt = 0;
    private void Update()
    {
        if (Cnum1 != -1 && ChangeCnt == 0)
        {
            ChangeCnt=1;

        }
        else if (Cnum2 != -1 && ChangeCnt == 1)
        {
            ChangeCnt=2;
        }
        else if (ChangeCnt == 2)
        {
            ChangeCnt = 0;
            swap_all(Cnum1, Cnum2, GameObject.Find("Inventory").GetComponent<Inventory>().items, GameObject.Find("player").GetComponent<PlayerClickItem>().item_array);
            Cnum1 = -1;
            Cnum2 = -1;
        }


    }

    void swap_all(int a, int b, List<Item> item_Item, List<string> item_string)
    {
        swap_array(a, b, item_string);
        swap_list(a, b, item_Item);
    }
    void swap_list(int a, int b, List<Item> item_Item)
    {
        Item ab;
        ab = item_Item[a];
        item_Item[a] = item_Item[b];
        item_Item[b] = ab;
        GameObject.Find("Inventory").GetComponent<Inventory>().FreshSlot();
    }
    void swap_array(int a, int b, List<string> item_)
    {
        string ab;
        ab = item_[a];
        item_[a] = item_[b];
        item_[b] = ab;
    }

}