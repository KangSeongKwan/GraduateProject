using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSelect : MonoBehaviour
{
    public static List<GameObject> items = new List<GameObject>();
    public GameObject[] WeightedItem;
    public GameObject[] Instantiates;
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
        GameObject.Find("RandomCard").GetComponent<RandomCard>().ShowRewardItem();
        WeightedItem = GameObject.Find("RandomCard").GetComponent<RandomCard>().rewardItems;
        for (int i = 0; i < 3; i++)
        {
            items.Add(WeightedItem[i]);
        }
        Instantiates[0] = Instantiate(items[0], Ppos0, Quaternion.identity);
        Instantiates[1] = Instantiate(items[1], Ppos1, Quaternion.identity);
        Instantiates[2] = Instantiate(items[2], Ppos2, Quaternion.identity);
    }
    
    public void CreateSpecial()
    {
        GameObject.Find("RandomCard").GetComponent<RandomCard>().ShowStoreItem();
        WeightedItem = GameObject.Find("RandomCard").GetComponent<RandomCard>().storeItems;
        for (int i = 0; i < 3; i++)
        {
            items.Add(WeightedItem[i]);
        }
        Instantiates[0] = Instantiate(items[0], Ppos0, Quaternion.identity);
        Instantiates[1] = Instantiate(items[1], Ppos1, Quaternion.identity);
        Instantiates[2] = Instantiate(items[2], Ppos2, Quaternion.identity);
    }

    public void CreateStore()
    {
        GameObject.Find("RandomCard").GetComponent<RandomCard>().ShowArtifactItem();
        WeightedItem = GameObject.Find("RandomCard").GetComponent<RandomCard>().artifactItems;
        for (int i = 0; i < 3; i++)
        {
            items.Add(WeightedItem[i]);
        }
        Instantiates[0] = Instantiate(items[0], Ppos0, Quaternion.identity);
        Instantiates[1] = Instantiate(items[1], Ppos1, Quaternion.identity);
        Instantiates[2] = Instantiate(items[2], Ppos2, Quaternion.identity);
    }
}