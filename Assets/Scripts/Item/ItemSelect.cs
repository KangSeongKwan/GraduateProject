using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSelect : MonoBehaviour
{
    public static List<GameObject> items = new List<GameObject>();
    public GameObject[] prefabs;
    public GameObject[] Instantiates;
    public movement movement;
    public Transform Pposition;
    float PposX;
    Vector3 Ppos0;
    Vector3 Ppos1;
    Vector3 Ppos2;
    int SpawnObj;

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
            Destroy(other.gameObject);
            CreateReward();
        }
    }
    public void DeleteItemList()
    {
        int i = 0;
        for (; i < 3; i++)
        {
            //그러므로 Field에 오브젝트를 배치하는 작업을 완료한 Object를 삭제해야 에러가 안남
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
        //player의 prefabs에 등록되어있는 것은 필드에 있는게 아니라 Sample Object임
        Instantiates[0] = Instantiate(items[0], Ppos0, Quaternion.identity);
        Instantiates[1] = Instantiate(items[1], Ppos1, Quaternion.identity);
        Instantiates[2] = Instantiate(items[2], Ppos2, Quaternion.identity);
    }
}