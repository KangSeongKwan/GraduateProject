using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSelect : MonoBehaviour
{
    public static List<GameObject> items = new List<GameObject>();
    public GameObject[] prefabs;
    public GameObject[] storePrefabs;
    public GameObject[] Instantiates;
    public GameObject[] Special;
    public movement movement;
    public Transform Pposition;
    float PposX;
    Vector3 Ppos0;
    Vector3 Ppos1;
    Vector3 Ppos2;
    int SpawnObj;
    private void Start()
    {
        Ppos1 = transform.position;
        Ppos0 = transform.position + new Vector3(-2, 0, 0);
        Ppos2 = transform.position + new Vector3(2, 0, 0);
        CreateSpecial();

    }
    void Update()
    {
        Ppos1 = transform.position;
        Ppos0 = transform.position + new Vector3(-2, 0, 0);
        Ppos2 = transform.position + new Vector3(2, 0, 0);
    }

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "event")
        {
            GameObject.Find("player").GetComponent<Click_Move>().click = false;
            Destroy(other.gameObject);
            CreateReward();
        }

        if (other.gameObject.tag == "store")
        {
            GameObject.Find("player").GetComponent<Click_Move>().click = false;
            Destroy(other.gameObject);
            CreateStore();
        }
    }
    public void DeleteItemList()
    {
        int i = 0;
        for (; i < 3; i++)
        {
            Destroy(Instantiates[i]);
        }
        items.Clear();
        
    }

    public void CreateReward()
    {
        for (int i = 0; i < 3; i++)
        {
            SpawnObj = Random.Range(1, 4);
            switch (SpawnObj)
            {
                case 1:
                    items.Add(prefabs[0]);
                    break;
                case 2:
                    items.Add(prefabs[1]);
                    break;
                case 3:
                    items.Add(prefabs[2]);
                    break;
                default:
                    Debug.Log("Error");
                    break;
            }

        }
        Instantiates[0] = Instantiate(items[0], Ppos0, Quaternion.identity);
        Instantiates[1] = Instantiate(items[1], Ppos1, Quaternion.identity);
        Instantiates[2] = Instantiate(items[2], Ppos2, Quaternion.identity);
    }
    public void CreateSpecial()
    {
        for (int i = 0; i < 3; i++)
        {
            SpawnObj = Random.Range(1, 4);
            switch (SpawnObj)
            {
                case 1:
                    items.Add(prefabs[0]);
                    break;
                case 2:
                    items.Add(prefabs[1]);
                    break;
                case 3:
                    items.Add(prefabs[2]);
                    break;
                default:
                    Debug.Log("Error");
                    break;
            }

        }
        Instantiates[0] = Instantiate(Special[0], Ppos0, Quaternion.identity);
        Instantiates[1] = Instantiate(Special[1], Ppos1, Quaternion.identity);
        Instantiates[2] = Instantiate(Special[2], Ppos2, Quaternion.identity);
    }

    public void CreateStore()
    {
        for (int i = 0; i < 3; i++)
        {
            SpawnObj = Random.Range(1, 4);
            switch (SpawnObj)
            {
                case 1:
                    items.Add(storePrefabs[0]);
                    break;
                case 2:
                    items.Add(storePrefabs[1]);
                    break;
                case 3:
                    items.Add(storePrefabs[2]);
                    break;
                default:
                    Debug.Log("Error");
                    break;
            }

        }
        //player�� prefabs�� ��ϵǾ��ִ� ���� �ʵ忡 �ִ°� �ƴ϶� Sample Object��
        Instantiates[0] = Instantiate(items[0], Ppos0, Quaternion.identity);
        Instantiates[1] = Instantiate(items[1], Ppos1, Quaternion.identity);
        Instantiates[2] = Instantiate(items[2], Ppos2, Quaternion.identity);
    }
}