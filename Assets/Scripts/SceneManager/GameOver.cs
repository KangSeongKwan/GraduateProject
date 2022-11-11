using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Image Panel;
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
        SceneManager.LoadScene("MainMenu");
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
}
