using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
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
    public void color_on()
    {
        image.color = new Color32(255, 255, 255, 150);
    }
    public void color_off()
    {
        image.color = new Color(1, 1, 1, 1);
    }
    
}
