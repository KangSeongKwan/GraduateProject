using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Count_Ani : MonoBehaviour
{
    // Start is called before the first frame update
    public Image[] C_A;
    void Start()
    {
        for (int a = 0; a < 3; a++)
        {
            C_A[a].gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        CameraManager CM = GameObject.Find("CameraManager").GetComponent<CameraManager>();
        if ((CM.mainCamera.enabled == true))
        {
            switch (GameObject.Find("BattleCount").GetComponent<BattleCount>().battleCount)
            {
                case 0:
                    C_A[0].gameObject.SetActive(true);
                    C_A[1].gameObject.SetActive(false);
                    C_A[2].gameObject.SetActive(false);
                    break;
                case 1:
                    C_A[0].gameObject.SetActive(false);
                    C_A[1].gameObject.SetActive(true);
                    C_A[2].gameObject.SetActive(false);
                    break;
                case 2:
                    C_A[0].gameObject.SetActive(false);
                    C_A[1].gameObject.SetActive(false);
                    C_A[2].gameObject.SetActive(true);
                    break;
            }
        }
        else if (CM.mainCamera.enabled == false)
        {
            C_A[0].gameObject.SetActive(false);
            C_A[1].gameObject.SetActive(false);
            C_A[2].gameObject.SetActive(false);
        }
    }
}
