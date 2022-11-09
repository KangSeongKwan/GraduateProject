using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class player_random : MonoBehaviour
{
    public static int move_point = 0;
    public bool roll = false;
    public Text count_text;
    SoundManager SoundEffect;
    int Randomobj;

    void Update()
    {
        count_text.text = move_point.ToString();
        click_space();
    }
    void click_space()
    {
        if (roll)
        {
            if (move_point == 0)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    move_point = Random.Range(1, 7);
                    GameObject.Find("PlayerStat").GetComponent<Unit>().currentHP -= 1;
                    Randomobj = Random.Range(1, 4);

                    switch (Randomobj)
                    {
                        case 1:
                            SoundEffect = GameObject.Find("SoundManager").GetComponent<SoundManager>();
                            SoundEffect.SFXPlay("audioDice1");
                            break;

                        case 2:
                            SoundEffect = GameObject.Find("SoundManager").GetComponent<SoundManager>();
                            SoundEffect.SFXPlay("audioDice2");
                            break;

                        case 3:
                            SoundEffect = GameObject.Find("SoundManager").GetComponent<SoundManager>();
                            SoundEffect.SFXPlay("audioDice3");
                            break;
                    }
                }
            }
        }
    }
}
