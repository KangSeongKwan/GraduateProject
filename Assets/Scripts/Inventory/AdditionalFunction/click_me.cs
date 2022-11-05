using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class click_me : MonoBehaviour, IPointerClickHandler
{
    public string num;
    public int array;
    public int ChangeCnt;
    public Text warning_ms;
    SoundManager SoundEffect;

    void Start()
    {
        warning_ms.gameObject.SetActive(false);
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {

            if (GameObject.Find("player").GetComponent<EnemyContact>().delete_on)
            {
                delete();
            }
            if (GameObject.Find("player").GetComponent<EnemyContact>().swap_on)
            {
                ChangeCnt = GameObject.Find("Inventory").GetComponent<Switch>().ChangeCnt;
                Click_switch();
            }
        }
    }
    private void Click_switch()
    {
        SoundEffect = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        GameObject clickObject = EventSystem.current.currentSelectedGameObject;
        num = clickObject.name.Remove(0, 5);
        switch (num)
        {
            case "":
                array = 0;
                break;
            default:
                num = num.Replace("(", "");
                num = num.Replace(")", "");
                array = int.Parse(num);
                break;
        }
        if (ChangeCnt == 0)
        {
            if (GameObject.Find("player").GetComponent<PlayerClickItem>().item_array.Count - 1 >= array)
            {
                GameObject.Find("Inventory").GetComponent<Switch>().Cnum1 = array;
                SoundEffect.SFXPlay("audioIChange");
            }
            else
            {
                warning_ms.gameObject.SetActive(true);
                Invoke("Warning_M", 1f);
            }
        }
        else if (ChangeCnt == 1)
        {
            if (GameObject.Find("player").GetComponent<PlayerClickItem>().item_array.Count - 1 >= array)
            {
                GameObject.Find("Inventory").GetComponent<Switch>().Cnum2 = array;
                SoundEffect.SFXPlay("audioIChange");
            }
                
            else
            {
                warning_ms.gameObject.SetActive(true);
                Invoke("Warning_M", 1f);
            }
        }
    }

    private void delete()
    {
        SoundEffect = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        GameObject clickObject = EventSystem.current.currentSelectedGameObject;
        num = clickObject.name.Remove(0, 5);
        switch (num)
        {
            case "":
                array = 0;
                break;
            default:
                num = num.Replace("(", "");
                num = num.Replace(")", "");
                array = int.Parse(num);
                break;
        }
        if (GameObject.Find("player").GetComponent<PlayerClickItem>().item_array.Count - 1 >= array)
        {
            SoundEffect.SFXPlay("audioIDiscard");
            GameObject.Find("Inventory").GetComponent<delete>().dnum = array;
            GameObject.Find("Inventory").GetComponent<delete>().Changedel = 1;
        }
        else
        {
            warning_ms.gameObject.SetActive(true);
            Invoke("Warning_M", 1f);
        }
    }
    void Warning_M()
    {
        warning_ms.gameObject.SetActive(false);
    }
}