using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_left : MonoBehaviour
{
    SoundManager SoundEffect;
    private void OnMouseDown() 
    {
        SoundEffect = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        SoundEffect.SFXPlay("audioMove");
        GameObject.Find("player").GetComponent<Click_Move>().ButtonLeft(); //이동 스크립트에 존재하는 모든 버튼 다 비활성화 함수
    }
}

