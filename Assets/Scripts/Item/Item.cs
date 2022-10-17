using UnityEngine;
using System;

// Project 창에서 Item 객체 생성해주는 스크립트
[CreateAssetMenu]
public class Item : ScriptableObject
{
    public string itemName;
    public Sprite itemImage;
    public Item item;
    public string abc;
}