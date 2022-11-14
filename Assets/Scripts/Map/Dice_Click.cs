using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice_Click : MonoBehaviour
{
    Animator animator;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<player_random>().Dice)
        {
            animator.SetBool("Bool", false);
        }
        else
            animator.SetBool("Bool", true);
    }
}
