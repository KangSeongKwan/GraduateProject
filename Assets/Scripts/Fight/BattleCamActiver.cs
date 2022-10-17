using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleCamActiver : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            GameObject.Find("CameraManager").GetComponent<CameraManager>().subCameraOn();
            GameObject.Find("player").GetComponent<PlayerClickItem>().enabled = false;
            GameObject.Find("BattleSYSTEM").transform.Find("Battle System").gameObject.SetActive(true);
            GameObject.Find("Battle System").GetComponent<BattleSystem>().StartBattle();
            Debug.Log("전투시작");
        }
    }
}
