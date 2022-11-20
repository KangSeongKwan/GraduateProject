using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveRule : MonoBehaviour
{
    public Image image;
    public bool chk = false;
    public Button[] Bbutton;
    MainMenuSound SoundEffect;
    int Randomobj;
    private void Start()
    {
        image.gameObject.SetActive(chk);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if(chk == false)
            {
                Randomobj = Random.Range(1, 4);

                switch (Randomobj)
                {
                    case 1:
                        SoundEffect = GameObject.Find("SoundManager").GetComponent<MainMenuSound>();
                        SoundEffect.SFXPlay("audioBookOpen1");
                        break;

                    case 2:
                        SoundEffect = GameObject.Find("SoundManager").GetComponent<MainMenuSound>();
                        SoundEffect.SFXPlay("audioBookOpen2");
                        break;

                    case 3:
                        SoundEffect = GameObject.Find("SoundManager").GetComponent<MainMenuSound>();
                        SoundEffect.SFXPlay("audioBookOpen3");
                        break;
                }
                chk = true;
                image.gameObject.SetActive(chk);
            }
            else
            {
                chk = false;
                image.gameObject.SetActive(chk);
                for(int i = 0; i < 3; i++)
                {
                    Bbutton[i].gameObject.SetActive(false);
                }
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
                image.gameObject.SetActive(false);

            }
        }
    }
}
