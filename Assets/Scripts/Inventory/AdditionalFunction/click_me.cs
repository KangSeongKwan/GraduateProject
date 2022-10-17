using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class click_me : MonoBehaviour, IPointerClickHandler
{
    public string num;
    public int array;
    public int ChangeCnt;
    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Left)
        {
            ChangeCnt = GameObject.Find("Inventory").GetComponent<Switch>().ChangeCnt;
            ClickBtn();
        }
    }
    private void ClickBtn()
    {
        GameObject clickObject = EventSystem.current.currentSelectedGameObject;
        num = clickObject.name.Remove(0, 5);
        switch (num)
        {
            case "":
                array = 0;
                break;
            default:
                num = num.Replace("(","");
                num = num.Replace(")", "");
                array = int.Parse(num);
                break;
        }
        if (ChangeCnt == 0)
        {
            GameObject.Find("Inventory").GetComponent<Switch>().Cnum1 = array;
        }
        else if (ChangeCnt == 1)
        {
            GameObject.Find("Inventory").GetComponent<Switch>().Cnum2 = array;
        }
        //GameObject.Find("Inventory").GetComponent<delete>().del(array, GameObject.Find("Inventory").GetComponent<Inventory>().items, GameObject.Find("player").GetComponent<PlayerClickItem>().item_array);
    }
}