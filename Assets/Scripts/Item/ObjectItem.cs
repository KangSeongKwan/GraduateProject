using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// 아이템 정보를 저장할 인터페이스
public interface IObjectItem
{
    Item ClickItem();
}

// 아이템 습득에 관한 스크립트
public class ObjectItem : MonoBehaviour, IObjectItem
{
    [Header("아이템")]
    public Item item;
    [Header("아이템 이미지")]
    public SpriteRenderer image;

    public Item ClickItem()
    {
        return this.item;
    }
    public void SetItem(Item _item)
    {
        item.itemName = _item.itemName;
        item.itemImage = _item.itemImage;
    }
}
