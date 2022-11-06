using UnityEngine;
using System;

// Project â���� Item ��ü �������ִ� ��ũ��Ʈ
[CreateAssetMenu]
[System.Serializable]
public class Item : ScriptableObject
{
    public string itemName;
    public Sprite itemImage;
    public Item item;
    public string abc;
    public string rank;
    public string condition;
    public string tag; // ������ ������
}