using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public static ItemDatabase instance;
    private void Awake()
    {
        instance = this;
    }

    // List 형태의 itemDatabase를 생성한다.
    public List<Item> itemDB = new List<Item>();

    public GameObject fieldItemPrefab;
    public Vector3[] pos;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (other.gameObject.transform.position == transform.position)
            {
                Destroy(gameObject);
                for (int i = 0; i < 3; i++)
                {
                    GameObject go = Instantiate(fieldItemPrefab, pos[i], Quaternion.identity);
                    go.GetComponent<ObjectItem>().SetItem(itemDB[Random.Range(0, 3)]);
                }
            }
        }
    }
}
