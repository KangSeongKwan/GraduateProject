using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_mv : MonoBehaviour
{
    public int m_p;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player_random.move_point != 0)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                transform.position += new Vector3(0, 1, 0);
                player_random.move_point--;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.position += new Vector3(-1, 0, 0);
                player_random.move_point--;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                transform.position += new Vector3(0, -1, 0);
                player_random.move_point--;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.position += new Vector3(1, 0, 0);
                player_random.move_point--;
            }
        }

    }

}
