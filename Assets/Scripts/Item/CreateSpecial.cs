using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSpecial : MonoBehaviour
{
    public static List<GameObject> items = new List<GameObject>();
    public GameObject[] prefabs;
    public GameObject[] storePrefabs;
    public GameObject[] Instantiates;
    public movement movement;
    public Transform Pposition;
    float PposX;
    Vector3 Ppos0;
    Vector3 Ppos1;
    Vector3 Ppos2;
    int SpawnObj;

    void Start()
    {
        GameObject.Find("player").GetComponent<Click_Move>().click = false;
        CreateReward();
    }

    // Update is called once per frame
    void Update()
    {
        Ppos1 = transform.position;
        Ppos0 = transform.position + new Vector3(-2, 0, 0);
        Ppos2 = transform.position + new Vector3(2, 0, 0);
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
    public void DeleteItemList()
    {
        int i = 0;
        for (; i < 3; i++)
        {
            Destroy(Instantiates[i]);
        }
        items.Clear();
    }
}
