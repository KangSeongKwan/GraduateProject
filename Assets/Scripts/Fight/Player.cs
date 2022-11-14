using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
    }
    public void Player_ATK()
    {
        animator.SetTrigger("ATK");
    }
    public void Player_HEAL()
    {
        animator.SetTrigger("HEAL");
    }
}
