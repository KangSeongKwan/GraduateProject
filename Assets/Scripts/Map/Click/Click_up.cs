using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_up : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameObject.Find("player").GetComponent<Click_Move>().ButtonUp(); //�̵� ��ũ��Ʈ�� �����ϴ� ��� ��ư �� ��Ȱ��ȭ �Լ�
    }
}
