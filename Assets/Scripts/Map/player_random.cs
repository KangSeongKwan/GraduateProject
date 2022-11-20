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
    public GameObject[] dice;
    GameObject diceprefab;
    Vector3 trans;
    Vector3 spot;
    public bool Dice = true;
    public int M_P = 0;
    GameObject spotlight;
    public GameObject asset_spotlight;

    void Update()
    {
        count_text.text = move_point.ToString();
        trans = gameObject.transform.position + new Vector3(0, 1f, 0);
        spot = gameObject.transform.position + new Vector3(0, 1.5f, 0);
        if (move_point == 0) // ����
        {
            Dice = true;
        }
        else
            Dice = false;
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
                    M_P = Random.Range(1, 7);
                    roll_ani(M_P);
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
    void roll_ani(int num)
    {
        spotlight = Instantiate(asset_spotlight, spot, Quaternion.identity);
        switch (num)
        {
            case 1:
                diceprefab = Instantiate(dice[0], trans, Quaternion.identity);
                break;
            case 2:
                diceprefab = Instantiate(dice[1], trans, Quaternion.identity);
                break;
            case 3:
                diceprefab = Instantiate(dice[2], trans, Quaternion.identity);
                break;
            case 4:
                diceprefab = Instantiate(dice[3], trans, Quaternion.identity);
                break;
            case 5:
                diceprefab = Instantiate(dice[4], trans, Quaternion.identity);
                break;
            case 6:
                diceprefab = Instantiate(dice[5], trans, Quaternion.identity);
                break;
        }
    }
    public void click_Dice()
    {
        if (roll)
        {
            if (move_point == 0)
            {
                    move_point = Random.Range(1, 7);
                    roll_ani(move_point);
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
    void Del_dice()
    {
        Destroy(spotlight);
        Destroy(diceprefab);
    }
}
