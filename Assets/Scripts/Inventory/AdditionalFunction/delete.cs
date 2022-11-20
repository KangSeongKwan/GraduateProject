using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class delete : MonoBehaviour
{
    public int dnum;
    public Button No_Button_delete;
    public Button OK_Button_delete;
    public int Changedel = 0;
    SoundManager SoundEffect;

    private void Start()
    {
        OK_Button_delete.gameObject.SetActive(false);
        No_Button_delete.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Changedel == 1)
        {
            GameObject.Find("Inventory").GetComponent<Inventory>().slots[dnum].color_on();
            OK_Button_delete.gameObject.SetActive(true);
            No_Button_delete.gameObject.SetActive(true);
        }
    }
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
    public void delete_button_on()
    {
        GameObject.Find("Inventory").GetComponent<Inventory>().slots[dnum].color_off();
        del(dnum, GameObject.Find("Inventory").GetComponent<Inventory>().items, GameObject.Find("player").GetComponent<PlayerClickItem>().item_array);
        GameObject.Find("player").GetComponent<EnemyContact>().delete_on = false;
        OK_Button_delete.gameObject.SetActive(false);
        No_Button_delete.gameObject.SetActive(false);
        GameObject.Find("player").GetComponent<Click_Move>().click = true;
        GameObject.Find("player").GetComponent<player_random>().roll = true; ;
        GameObject.Find("CanvasInventory").GetComponent<InventoryActive>().activeInventory = false;
        Changedel = 0;
    }
    public void button_off()
    {
        OK_Button_delete.gameObject.SetActive(false);
        No_Button_delete.gameObject.SetActive(false);
        GameObject.Find("Inventory").GetComponent<Inventory>().slots[dnum].color_off();
        Changedel = 0;
    }
    public void DeleteSound()
    {
        SoundEffect = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        SoundEffect.SFXPlay("audioIDiscard");
    }
}