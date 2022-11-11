using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSelectItem : MonoBehaviour
{
    public static List<GameObject> AttkCard = new List<GameObject>();
    public static List<GameObject> HealCard = new List<GameObject>();
    public GameObject BaseBorad;
    public GameObject[] Attkprefabs;
    public GameObject[] Healprefabs;
    public GameObject[] CardInstantiates;
    int SpawnObjCard;

    public void SelectAttackCard()
    {
        SpawnObjCard = Random.Range(1, 4);
        switch (SpawnObjCard)
        {
            case 1:
                AttkCard.Add(Attkprefabs[0]);
                break;
            case 2:
                AttkCard.Add(Attkprefabs[1]);
                break;
            case 3:
                AttkCard.Add(Attkprefabs[2]);
                break;
            default:
                Debug.Log("Error");
                break;
        }
    }

    public void SelectHealCard()
    {
        SpawnObjCard = Random.Range(1, 4);
        switch (SpawnObjCard)
        {
            case 1:
                HealCard.Add(Healprefabs[0]);
                break;
            case 2:
                HealCard.Add(Healprefabs[1]);
                break;
            case 3:
                HealCard.Add(Healprefabs[2]);
                break;
            default:
                Debug.Log("Error");
                break;
        }
    }

    public void SetCard()
    {
        SelectAttackCard();
        SelectHealCard();
        CardInstantiates[0] = Instantiate(AttkCard[0], new Vector3(-504, 299, 0), Quaternion.identity);
        CardInstantiates[1] = Instantiate(HealCard[0], new Vector3(-496, 299, 0), Quaternion.identity);
        CardInstantiates[2] = Instantiate(BaseBorad, new Vector3(-500,300,0), Quaternion.identity);
    }

    public void DeleteBattleItemList()
    {
        int i = 0;
        for (; i < 3; i++)
        {
            //Field�� ������Ʈ�� ��ġ�ϴ� �۾��� �Ϸ��� Object�� �����ؾ� ������ �ȳ�
            Destroy(CardInstantiates[i]);
        }
        AttkCard.Clear();
        HealCard.Clear();
    }
}
