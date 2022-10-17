using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class player_random : MonoBehaviour
{
    public static int move_point = 0;
    public int max_count = 6;
    public Text count_text;
    void Update()
    {
        count_text.text = move_point.ToString();
        click_space();
    }
    void click_space()
    {
        if (move_point == 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                move_point = Random.Range(1, max_count);
                max_count++;
            }
        }
    }
}
