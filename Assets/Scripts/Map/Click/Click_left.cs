using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_left : MonoBehaviour
{
    private void OnMouseDown() 
    {
        GameObject.Find("player").GetComponent<Click_Move>().ButtonLeft(); //이동 스크립트에 존재하는 모든 버튼 다 비활성화 함수
    }
}

