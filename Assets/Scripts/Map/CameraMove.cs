using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �̴ϸ� ī�޶� Ȱ��/��Ȱ�� ����
        if (Input.GetKey(KeyCode.M))
        {
            GameObject.Find("MiniCAM").transform.Find("MiniCam").gameObject.SetActive(true);
        }
        else if (Input.GetKeyUp(KeyCode.M))
        {
            GameObject.Find("MiniCam").SetActive(false);
        }
    }
}
