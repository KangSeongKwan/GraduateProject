using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_left : MonoBehaviour
{
    private void OnMouseDown() 
    {
        GameObject.Find("player").GetComponent<Click_Move>().ButtonLeft(); //�̵� ��ũ��Ʈ�� �����ϴ� ��� ��ư �� ��Ȱ��ȭ �Լ�
    }
}

