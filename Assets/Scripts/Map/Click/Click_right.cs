using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_right : MonoBehaviour    // Ŭ�� �� ���� �̵�
{
    private void OnMouseDown()
    {
        GameObject.Find("player").GetComponent<Click_Move>().ButtonRight(); //�̵� ��ũ��Ʈ�� �����ϴ� ��� ��ư �� ��Ȱ��ȭ �Լ�
    }
}
