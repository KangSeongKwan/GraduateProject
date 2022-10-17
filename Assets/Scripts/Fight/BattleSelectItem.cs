using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSelectItem : MonoBehaviour
{
    public static List<GameObject> AttkCard = new List<GameObject>();
    public static List<GameObject> HealCard = new List<GameObject>();
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
        CardInstantiates[0] = Instantiate(AttkCard[0], new Vector3(-510, 300, 0), Quaternion.identity);
        CardInstantiates[1] = Instantiate(HealCard[0], new Vector3(-490, 300, 0), Quaternion.identity);
    }

    public void DeleteBattleItemList()
    {
        int i = 0;
        for (; i < 2; i++)
        {
            //Field에 오브젝트를 배치하는 작업을 완료한 Object를 삭제해야 에러가 안남
            Destroy(CardInstantiates[i]);
        }
        AttkCard.Clear();
        HealCard.Clear();
    }
}
