using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_down : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameObject.Find("player").GetComponent<Click_Move>().ButtonDown(); //�̵� ��ũ��Ʈ�� �����ϴ� ��� ��ư �� ��Ȱ��ȭ �Լ�
    }
}
