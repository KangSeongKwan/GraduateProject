using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHP : MonoBehaviour
{
    public Text HP;
    public int PlayerHealth;
    void Update()
    {
        Unit Php = GameObject.Find("PlayerStat").GetComponent<Unit>();
        PlayerHealth = Php.currentHP;
        if (PlayerHealth <= 0)
        {
            HP.text = "HP : 0";
        }
        else
        {
            HP.text = "HP : " + Php.currentHP.ToString();
        }
    }
}
