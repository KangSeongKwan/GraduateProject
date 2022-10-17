using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat : MonoBehaviour
{
    // ¸â¹ö º¯¼ö
    [SerializeField]
    protected int _hp;
    [SerializeField]
    protected int _maxHp;
    [SerializeField]
    protected int _attack;


    // ¸â¹ö ÇÁ·ÎÆÛÆ¼
    public int Hp { get { return _hp; } set { _hp = value; } }
    public int MaxHp { get { return _maxHp; } set { _maxHp = value; } }
    public int Attack { get { return _attack; } set { _attack = value; } }


    private void Start()
    {
        _hp = 100;
        _maxHp = 100;
        _attack = 10;
    }
}
