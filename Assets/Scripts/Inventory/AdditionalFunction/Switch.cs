using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Switch : MonoBehaviour
{
    public int Cnum1 = -1;
    public int Cnum2 = -1;
    public int ChangeCnt = 0;
    public Button No_Button;
    public Button OK_Button_swap;
    SoundManager SoundEffect;

    private void Start()
    {
        OK_Button_swap.gameObject.SetActive(false);
        No_Button.gameObject.SetActive(false);
    }
    private void Update()
    {
        if (Cnum1 != -1 && ChangeCnt == 0)
        {
            ChangeCnt = 1;

        }
        else if (Cnum2 != -1 && ChangeCnt == 1)
        {
            ChangeCnt = 2;
        }
        else if (ChangeCnt == 2)
        {
            OK_Button_swap.gameObject.SetActive(true);
            No_Button.gameObject.SetActive(true);
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
    public void swap_button_on()
    {
        ChangeCnt = 0;
        swap_all(Cnum1, Cnum2, GameObject.Find("Inventory").GetComponent<Inventory>().items, GameObject.Find("player").GetComponent<PlayerClickItem>().item_array);
        Cnum1 = -1;
        Cnum2 = -1;
        OK_Button_swap.gameObject.SetActive(false);
        No_Button.gameObject.SetActive(false);
        GameObject.Find("player").GetComponent<EnemyContact>().swap_on = false;
        GameObject.Find("player").GetComponent<Click_Move>().click = true;
        GameObject.Find("player").GetComponent<player_random>().roll = true;
        GameObject.Find("CanvasInventory").GetComponent<InventoryActive>().activeInventory = false;
    }
    public void Button_off()
    {
        OK_Button_swap.gameObject.SetActive(false);
        No_Button.gameObject.SetActive(false);
        ChangeCnt = 0;
        Cnum1 = -1;
        Cnum2 = -1;
    }
    public void SwapSound()
    {
        SoundEffect = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        SoundEffect.SFXPlay("audioIChange");
    }
}