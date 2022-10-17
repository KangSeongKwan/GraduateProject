using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerClickItem : MonoBehaviour
{
    // �÷��̾ �������� �����ϴ� ������ �����ϴ� ��ũ��Ʈ
    [Header("�κ��丮")]
    public Inventory inventory;
    public List<string> item_array;
    
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
            Debug.Log(GameObject.Find("player").GetComponent<calculator>().cal(1, item_array)); // ���
        }
    }
    void HitCheckObject(RaycastHit2D hit)
    {
        IObjectItem clickInterface = hit.transform.gameObject.GetComponent<IObjectItem>();

        if (clickInterface != null)
        {
            Item item = clickInterface.ClickItem();
            print($"{item.itemName}");
            inventory.AddItem(item);
            item_array.Add(item.abc);
            //������Ʈ ������ ���⼭ �ؾ���
            GameObject.Find("player").GetComponent<ItemSelect>().DeleteItemList();
            //���� : HitCheckObject���� Ŭ�� �̺�Ʈ�� ó�����ֹǷ�, ���⼭ �κ��丮 �ݿ��� ���ÿ� �ı��� ó���ϸ��
        }
    }
}