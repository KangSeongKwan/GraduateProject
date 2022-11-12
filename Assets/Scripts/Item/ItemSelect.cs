using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSelect : MonoBehaviour
{
    public static List<GameObject> items = new List<GameObject>();
    public GameObject[] WeightedItem;
    public GameObject[] WeightedStore;
    public GameObject[] WeightedArtifact;
    public GameObject[] Instantiates;
    public movement movement;
    public Transform Pposition;
    float PposX;
    Vector3 Ppos0;
    Vector3 Ppos1;
    Vector3 Ppos2;
    int SpawnObj;
    SoundManager SoundEffect;

    private int count = 0;

    void Start()
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
            Invoke("CreateReward", 0.175f);   //Ãæµ¹ ½Ã
        }

        if (other.gameObject.tag == "store")
        {
            SoundEffect = GameObject.Find("SoundManager").GetComponent<SoundManager>();
            SoundEffect.SFXPlay("audioShop");
            GameObject.Find("player").GetComponent<Click_Move>().click = false;
            GameObject.Find("player").GetComponent<player_random>().roll = false;
            Destroy(other.gameObject);
            Invoke("CreateStore", 0.175f);
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

        InvokeRepeating("CardSound", 0.5f, 0.2f);
        count = 0;
    }
    
    public void CreateSpecial()
    {
        GameObject.Find("RandomCard").GetComponent<RandomCard>().ShowArtifactItem();
        WeightedArtifact = GameObject.Find("RandomCard").GetComponent<RandomCard>().artifactItems;
        for (int i = 0; i < 3; i++)
        {
            items.Add(WeightedArtifact[i]);
        }
        Instantiates[0] = Instantiate(items[0], Ppos0, Quaternion.identity);
        Instantiates[1] = Instantiate(items[1], Ppos1, Quaternion.identity);
        Instantiates[2] = Instantiate(items[2], Ppos2, Quaternion.identity);
        GameObject.Find("player").GetComponent<Click_Move>().click = false;
        InvokeRepeating("CardSound", 0.5f, 0.2f);

        count = 0;
    }

    public void CreateStore()
    {
        GameObject.Find("RandomCard").GetComponent<RandomCard>().ShowStoreItem();
        WeightedStore = GameObject.Find("RandomCard").GetComponent<RandomCard>().storeItems;
        for (int i = 0; i < 3; i++)
        {
            items.Add(WeightedStore[i]);
        }
        Instantiates[0] = Instantiate(items[0], Ppos0, Quaternion.identity);
        Instantiates[1] = Instantiate(items[1], Ppos1, Quaternion.identity);
        Instantiates[2] = Instantiate(items[2], Ppos2, Quaternion.identity);
    }

    public void CardSound()
    {
        SoundEffect = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        SoundEffect.SFXPlay("audioCardList");
        count += 1;
        if(count >=3)
        {
            CancelInvoke("CardSound");
        }
    }
}