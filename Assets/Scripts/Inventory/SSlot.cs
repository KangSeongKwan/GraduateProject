using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SSlot : MonoBehaviour
{
    [SerializeField] Image image;   //Image Component ������ ���

    private Item _item; //item ������ ���� ����
    public Item item //Item ��ü�� �޾ƿ� �� �ִ� ��ũ��Ʈ
    {
        get { return _item; }
        set
        {
            _item = value;
            if (_item != null)
            {
                image.sprite = item.itemImage;
                image.color = new Color(1, 1, 1, 1);
            }
            else
            {
                image.color = new Color(1, 1, 1, 0);
            }
        }
    }
    
}