using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BattleClickItem : MonoBehaviour
{
    Camera CamerSub;
    public string NameOfCard;
    public string[] ValueOfCardList;
    public string TypeOfCard;

    public bool isClickSuccess = false;
    void Update()
    {
        CamerSub = GameObject.Find("CameraManager").GetComponent<CameraManager>().subCamera;

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = CamerSub.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);

            if (hit.collider != null)
            {
                HitCheckObject(hit);
            }
        }
    }
    void HitCheckObject(RaycastHit2D hit)
    {
        Debug.Log(hit.collider.gameObject.name);
        NameOfCard = hit.collider.gameObject.name;
        BattleCardNamesplit();

        if (TypeOfCard == "ATK")
        {
            //클릭 동작을 호출한 후에 파괴하면 어떨까?
            isClickSuccess = true;
            GameObject.Find("Battle System").GetComponent<BattleSystem>().OnAttackButton();
        }
        else if(TypeOfCard == "HEAL")
        {
            //클릭 동작을 호출한 후에 파괴하면 어떨까?
            isClickSuccess = true;
            GameObject.Find("Battle System").GetComponent<BattleSystem>().OnHealButton();
        }
        
        if (isClickSuccess == true)
        {
            GameObject.Find("Battle System").GetComponent<BattleSelectItem>().DeleteBattleItemList();
        }
        else
        {
            Debug.Log("전투시스템 오류");
        }
    }

    public void BattleCardNamesplit()
    {
        ValueOfCardList = NameOfCard.Split(' ');
        TypeOfCard = ValueOfCardList[0];
    }
}
