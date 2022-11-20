using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    int Randomobj;
    public Image book;
    public Image Panel;
    MainMenuSound SoundEffect;
    ActiveRule Arule;
    float time = 0f;
    float F_time = 1f;
    public void StartBtn()
    {
        StartCoroutine(FadeFlowStart());
    }
    public void EndBtn()
    {
        StartCoroutine(FadeFlowEnd());
    }
    IEnumerator FadeFlowStart()
    {
        Panel.gameObject.SetActive(true);
        Color alpha = Panel.color;
        while(alpha.a < 1f)
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.Lerp(0,1,time);
            Panel.color = alpha;
            yield return null;
        }
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Backup1");
    }
        IEnumerator FadeFlowEnd()
    {
        Panel.gameObject.SetActive(true);
        Color alpha = Panel.color;
        while(alpha.a < 1f)
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.Lerp(0,1,time);
            Panel.color = alpha;
            yield return null;
        }
        yield return new WaitForSeconds(1f);
         Application.Quit();
    }
    public void RuleBtn()
    {
        Arule = GameObject.Find("RuleManager").GetComponent<ActiveRule>();
        book.gameObject.SetActive(true);
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
        Arule.chk = true;
    }
}
