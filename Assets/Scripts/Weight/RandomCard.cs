using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCard : MonoBehaviour
{
    public WeightedRandomList<GameObject> rewardList;
    public WeightedRandomList<GameObject> rewardDebuffList;
    public WeightedRandomList<GameObject> storeList;
    public WeightedRandomList<GameObject> artifactList;

    public GameObject[] storeItems;
    public GameObject[] rewardItems;
    public GameObject[] rewardDebuffItems;
    public GameObject[] artifactItems;

    public void ShowRewardItem()
    {
        for (int i=0; i < 3; i++)
        {
            rewardItems[i] = rewardList.GetRandom();
        }
        Debug.Log("Weight Insert Succeed");
    }

    public void ShowStoreItem()
    {
        for (int i = 0; i < 3; i++)
        {
            storeItems[i] = storeList.GetRandom();
        }
        Debug.Log("Weight Insert Succeed");
    }
    public void ShowArtifactItem()
    {
        for (int i = 0; i < 3; i++)
        {
            artifactItems[i] = artifactList.GetRandom();
        }
        Debug.Log("Weight Insert Succeed");
    }
    public void ShowRewardDebuffItem()
    {
        for (int i = 0; i < 3; i++)
        {
            rewardDebuffItems[i] = rewardDebuffList.GetRandom();
        }
        Debug.Log("Weight Insert Succeed");
    }
}
