using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_up : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameObject.Find("player").GetComponent<Click_Move>().ButtonUp(); //이동 스크립트에 존재하는 모든 버튼 다 비활성화 함수
    }
}
