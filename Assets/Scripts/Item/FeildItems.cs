using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FieldItems : MonoBehaviour
{
    // SO(Scriptable Object로 정의된 Item에 대해서 생성자를 통한 초기화를 진행해준다)
    public Item item;
    public SpriteRenderer image;

    public void SetItem(Item _item)
    {
        item.itemName = _item.itemName;
        item.itemImage = _item.itemImage;

        image.sprite = item.itemImage;
    }
}
