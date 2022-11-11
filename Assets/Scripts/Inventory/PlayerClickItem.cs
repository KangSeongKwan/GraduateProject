using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerClickItem : MonoBehaviour
{
    // 플레이어가 아이템을 습득하는 동작을 제어하는 스크립트
    [Header("인벤토리")]
    public Inventory inventory;
    public List<string> item_array;
    public string clickItemName;
    public string clickItemTag;
    public int artifactFlag;
    public Item sitem;
    SoundManager SoundEffect;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);

            if (hit.collider != null)
            {
                HitCheckObject(hit);
            }
        }
        if(Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log(GameObject.Find("player").GetComponent<calculator>().cal(0, item_array)); // 계산
        }
    }
    void HitCheckObject(RaycastHit2D hit)
    {
        IObjectItem clickInterface = hit.transform.gameObject.GetComponent<IObjectItem>();
        SoundEffect = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        
        if (clickInterface != null)
        {
            Item item = clickInterface.ClickItem();
            //print($"{item.itemName}");
            SoundEffect.SFXPlay("audioCardSelect");
            clickItemName = item.itemName;
            clickItemTag = item.tag;

            if (clickItemTag == "artifact")
            {
                sitem = item;
                inventory.AddSslot(item);
                Debug.Log(inventory.sslot.item.condition);
                artifactFlag++;
            }
            else
            {
                if(clickItemTag == "store")
                {
                    GameObject.Find("PlayerStat").GetComponent<Unit>().UseStore();
                    inventory.AddItem(item);
                    item_array.Add(item.abc);
                }
                else if(clickItemTag == "reward")
                {
                    inventory.AddItem(item);
                    item_array.Add(item.abc);
                }
                else if(clickItemTag == "hpincrease")
                {
                    GameObject.Find("PlayerStat").GetComponent<Unit>().MaxHPIncrease();
                }
            }
            //오브젝트 삭제는 여기서 해야함
            GameObject.Find("player").GetComponent<ItemSelect>().DeleteItemList();
            //이유 : HitCheckObject에서 클릭 이벤트를 처리해주므로, 여기서 인벤토리 반영과 동시에 파괴를 처리하면됨
        }
    }
}