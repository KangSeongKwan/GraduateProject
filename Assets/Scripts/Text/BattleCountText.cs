using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BattleCountText : MonoBehaviour
{
    public Text battleCount;
    void Update()
    {
        BattleCount Bcount = GameObject.Find("BattleCount").GetComponent<BattleCount>();
        CameraManager CM = GameObject.Find("CameraManager").GetComponent<CameraManager>();
        battleCount.text = Bcount.battleCount.ToString();
        if (CM.mainCamera.enabled == true)
        {
            battleCount.enabled = true;
        }
        else if (CM.mainCamera.enabled == false)
        {
            battleCount.enabled = false;
        }
    }
}
