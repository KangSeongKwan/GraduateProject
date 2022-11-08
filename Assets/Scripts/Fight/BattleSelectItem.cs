using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSelectItem : MonoBehaviour
{
    public WeightedRandomList<GameObject> battleAttackList;
    public WeightedRandomList<GameObject> battleHealList;
    public GameObject battleAttackItem;
    public GameObject battleHealItem;
    public GameObject[] CardInstantiates;

    public void SetCard()
    {
        ShowBattleAttackItem();
        ShowBattleHealItem();
        CardInstantiates[0] = Instantiate(battleAttackItem, new Vector3(-510, 300, 0), Quaternion.identity);
        CardInstantiates[1] = Instantiate(battleHealItem, new Vector3(-490, 300, 0), Quaternion.identity);
    }

    public void DeleteBattleItemList()
    {
        int i = 0;
        for (; i < 2; i++)
        {
            //Field�� ������Ʈ�� ��ġ�ϴ� �۾��� �Ϸ��� Object�� �����ؾ� ������ �ȳ�
            Destroy(CardInstantiates[i]);
        }
    }
    public void ShowBattleAttackItem()
    {
        battleAttackItem = battleAttackList.GetRandom();
        Debug.Log("Battle Weight Insert Succeed");
    }

    public void ShowBattleHealItem()
    {
        battleHealItem = battleHealList.GetRandom();
        Debug.Log("Battel Weight Insert Succeed");
    }
}
