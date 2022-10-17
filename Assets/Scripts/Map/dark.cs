using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dark : MonoBehaviour
{
    public GameObject darkPrfab;
    GameObject dark_create;
    void Start()
    {
        // 전장의 안개 시스템을 구현할 코드
        for (int x = -7; x < 7; x++)
        {
            for (int y = -7; y < 7; y++)
            {
                Vector3 positon = new Vector3(x, y, 0);
                dark_create = Instantiate(darkPrfab, positon, Quaternion.identity);
                dark_create.transform.parent = gameObject.transform;
            }
        }
    }
}