using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerATK : MonoBehaviour
{
    public Text ATK;
    public int InventoryDamage;
    void Update()
    {
        InventoryDamage = GameObject.Find("player").GetComponent<calculator>().cal(1, GameObject.Find("player").GetComponent<PlayerClickItem>().item_array);
        ATK.text = "ATK : " + InventoryDamage.ToString();
    }
}
