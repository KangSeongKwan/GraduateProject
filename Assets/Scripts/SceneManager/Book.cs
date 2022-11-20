using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Book : MonoBehaviour
{
    public GameObject[] pages;
    public int page = 0;
    public Button left_b;
    public Button right_b;
    public Button exit;
    Animator animator;
    MainMenuSound SoundEffect;
    int Randomobj;
    ActiveRule Arule;

    void Start()
    {
        this.animator = GetComponent<Animator>();
        for (int a = 1; a < 3; a++)
        {
            pages[a].SetActive(false);
            pages[page].SetActive(true);
        }
    }
    private void Update()
    {
        if (gameObject)
            exit.gameObject.SetActive(true);
        else
            exit.gameObject.SetActive(false);
        if (page == 0)
            left_b.gameObject.SetActive(false);
        else if (page != 0)
            left_b.gameObject.SetActive(true);
        if (page == 2)
            right_b.gameObject.SetActive(false);
        else if (page != 2)
            right_b.gameObject.SetActive(true);
    }

    public void left()
    {
        Randomobj = Random.Range(1, 6);
        animator.SetTrigger("left");
        pages[page--].SetActive(false);
        switch (Randomobj)
        {
            case 1:
                SoundEffect = GameObject.Find("SoundManager").GetComponent<MainMenuSound>();
                SoundEffect.SFXPlay("audioButton1");
                break;

            case 2:
                SoundEffect = GameObject.Find("SoundManager").GetComponent<MainMenuSound>();
                SoundEffect.SFXPlay("audioButton2");
                break;

            case 3:
                SoundEffect = GameObject.Find("SoundManager").GetComponent<MainMenuSound>();
                SoundEffect.SFXPlay("audioButton3");
                break;
            case 4:
                SoundEffect = GameObject.Find("SoundManager").GetComponent<MainMenuSound>();
                SoundEffect.SFXPlay("audioButton4");
                break;
            case 5:
                SoundEffect = GameObject.Find("SoundManager").GetComponent<MainMenuSound>();
                SoundEffect.SFXPlay("audioButton5");
                break;
        }
        Invoke("pageon", 0.233f);
    }
    public void right()
    {
        Randomobj = Random.Range(1, 6);
        animator.SetTrigger("right");
        pages[page++].SetActive(false);
        switch (Randomobj)
        {
            case 1:
                SoundEffect = GameObject.Find("SoundManager").GetComponent<MainMenuSound>();
                SoundEffect.SFXPlay("audioButton1");
                break;

            case 2:
                SoundEffect = GameObject.Find("SoundManager").GetComponent<MainMenuSound>();
                SoundEffect.SFXPlay("audioButton2");
                break;

            case 3:
                SoundEffect = GameObject.Find("SoundManager").GetComponent<MainMenuSound>();
                SoundEffect.SFXPlay("audioButton3");
                break;
            case 4:
                SoundEffect = GameObject.Find("SoundManager").GetComponent<MainMenuSound>();
                SoundEffect.SFXPlay("audioButton4");
                break;
            case 5:
                SoundEffect = GameObject.Find("SoundManager").GetComponent<MainMenuSound>();
                SoundEffect.SFXPlay("audioButton5");
                break;
        }
        Invoke("pageon", 0.233f);

    }
    void pageon()
    {
        pages[page].SetActive(true);
    }
    public void Exit_B()
    {
        Arule = GameObject.Find("RuleManager").GetComponent<ActiveRule>();
        Randomobj = Random.Range(1, 4);

        switch (Randomobj)
        {
            case 1:
                SoundEffect = GameObject.Find("SoundManager").GetComponent<MainMenuSound>();
                SoundEffect.SFXPlay("audioBookClose1");
                break;

            case 2:
                SoundEffect = GameObject.Find("SoundManager").GetComponent<MainMenuSound>();
                SoundEffect.SFXPlay("audioBookClose2");
                break;

            case 3:
                SoundEffect = GameObject.Find("SoundManager").GetComponent<MainMenuSound>();
                SoundEffect.SFXPlay("audioBookClose3");
                break;
        }
        left_b.gameObject.SetActive(false);
        right_b.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);
        gameObject.SetActive(false);
        Arule.chk = false;
    }
}
