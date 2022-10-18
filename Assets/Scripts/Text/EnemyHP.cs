using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyHP : MonoBehaviour
{
    public Text HP;
    public int EnemyHealth;
    void Update()
    {
        CameraManager CM = GameObject.Find("CameraManager").GetComponent<CameraManager>();
        if (CM.subCamera.enabled == true)
        {
            BattleSystem Ehp = GameObject.Find("Battle System").GetComponent<BattleSystem>();
            EnemyHealth = Ehp.EnemyHP;
            if(EnemyHealth <= 0)
            {
                HP.text = "HP : 0";
            }
            else
            {
                HP.text = "HP : " + Ehp.EnemyHP.ToString();
            }
        }
        else if (CM.subCamera.enabled == false)
        {
            HP.text = "HP";
        }
    }
}