using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCard : MonoBehaviour
{
    public WeightedRandomList<GameObject> rewardList;
    public WeightedRandomList<GameObject> storeList;
    public WeightedRandomList<GameObject> artifactList;
    public GameObject[] storeItems;
    public GameObject[] rewardItems;
    public GameObject[] artifactItems;

    public void ShowRewardItem()
    {
        for (int i=0; i < 3; i++)
        {
            rewardItems[i] = rewardList.GetRandom();
        }
    }
    public void ShowStoreItem()
    {
        for (int i = 0; i < 3; i++)
        {
            storeItems[i] = rewardList.GetRandom();
        }
    }
    public void ShowArtifactItem()
    {
        for (int i = 0; i < 3; i++)
        {
            artifactItems[i] = rewardList.GetRandom();
        }
    }
}
