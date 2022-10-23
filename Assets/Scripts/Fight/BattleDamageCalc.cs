using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleDamageCalc : MonoBehaviour
{
    public int FinalDamage;
    public int FinalHeal;
    public int CalculatedDamage;
    public int CalculatedHeal;
    int AddDamage;
    int AddHeal;
    public string itemName;
    public string[] ValueOfCard;
    string splitedCardStat;

    public int FinalDamageWithCard()
    {
        BattleCardDamagesplit();

        switch (ValueOfCard[0])
        {
            case "ATK":
                switch (ValueOfCard[1])
                {
                    case "+":
                        FinalDamage = CalculatedDamage + AddDamage;
                        Debug.Log(FinalDamage);
                        break;
                    case "-":
                        FinalDamage = CalculatedDamage - AddDamage;
                        Debug.Log(FinalDamage);
                        break;
                    case "x":
                        FinalDamage = CalculatedDamage * AddDamage;
                        Debug.Log(FinalDamage);
                        break;
                    case "%":
                        FinalDamage = CalculatedDamage / AddDamage;
                        Debug.Log(FinalDamage);
                        break;
                }
                break;
            case "HEAL":
                Debug.Log("This is a Heal Item");
                break;
        }
        return FinalDamage;
    }

    public int FinalHealWithCard()
    {
        BattleCardHealsplit();

        switch (ValueOfCard[0])
        {
            case "ATK":
                Debug.Log("This is a Attack Card");
                break;
            case "HEAL":
                switch (ValueOfCard[1])
                {
                    case "+":
                        FinalHeal += AddHeal;
                        Debug.Log(FinalHeal);
                        break;
                    case "x":
                        FinalHeal *= AddHeal;
                        Debug.Log(FinalHeal);
                        break;
                }
                break;
        }
        return FinalHeal;
    }

    public void BattleCardDamagesplit()
    {
        itemName = GameObject.Find("Battle System").GetComponent<BattleClickItem>().NameOfCard;
        CalculatedDamage = GameObject.Find("player").GetComponent<calculator>().cal(1, GameObject.Find("player").GetComponent<PlayerClickItem>().item_array);
        if (GameObject.Find("player").GetComponent<PlayerClickItem>().aaa == 1)
        {
            switch (GameObject.Find("player").GetComponent<PlayerClickItem>().sitem.condition)
            {
                case "Even":
                    if (CalculatedDamage % 2 == 0)
                    {
                        CalculatedDamage = GameObject.Find("player").GetComponent<calculator>().Cal1(CalculatedDamage, GameObject.Find("player").GetComponent<PlayerClickItem>().sitem.abc);
                    }
                    break;
                case "Odd":
                    if (CalculatedDamage % 2 == 1)
                    {
                        CalculatedDamage = GameObject.Find("player").GetComponent<calculator>().Cal1(CalculatedDamage, GameObject.Find("player").GetComponent<PlayerClickItem>().sitem.abc);
                    }
                    break;
                default:
                    break;
            }
        }
        ValueOfCard = itemName.Split(' ');
        splitedCardStat = ValueOfCard[2].Remove(1, 7);
        AddDamage = int.Parse(splitedCardStat);
    }

    public void BattleCardHealsplit()
    {
        itemName = GameObject.Find("Battle System").GetComponent<BattleClickItem>().NameOfCard;
        ValueOfCard = itemName.Split(' ');

        splitedCardStat = ValueOfCard[2].Remove(1, 7);
        AddHeal = int.Parse(splitedCardStat);
        FinalHeal = 0;
    }
}
// ¼öÁ¤