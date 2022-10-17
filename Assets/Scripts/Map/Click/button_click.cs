using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button_click : MonoBehaviour
{
    public Button btn1;
    // Update is called once per frame
    void Update()
    {
        if (!GameObject.Find("player").GetComponent<movement>().click)
        {
            btn1.gameObject.SetActive(true);
        }

    }
    public void Onclick()
    {
        GameObject.Find("player").GetComponent<movement>().click = true;
        btn1.gameObject.SetActive(false);
    }


}
