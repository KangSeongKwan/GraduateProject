using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainPlayerHP : MonoBehaviour
{
    public Text HP;
    void Update()
    {
        Unit Php = GameObject.Find("PlayerStat").GetComponent<Unit>();
        CameraManager CM = GameObject.Find("CameraManager").GetComponent<CameraManager>();
        HP.text = "HP : " + Php.currentHP.ToString();
        if (CM.mainCamera.enabled == true)
        {
            HP.enabled = true;
        }
        else if (CM.mainCamera.enabled == false)
        {
            HP.enabled = false;
        }
    }
}
