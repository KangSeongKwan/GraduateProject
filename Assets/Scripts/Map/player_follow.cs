using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_follow : MonoBehaviour
{

    public Transform player;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + new Vector3(0, 0 , -10);
    }
}
