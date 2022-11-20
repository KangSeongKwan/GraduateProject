using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Die : MonoBehaviour
{
    Unit unit;
        public Image Panel;
    float time = 0f;
    float F_time = 1f;
        void Update()
    {
        unit = GameObject.Find("PlayerStat").GetComponent<Unit>();        
        if(unit.currentHP <= 0)
        {
            StartCoroutine(FadeFlowStart());
            SceneManager.LoadScene("GameOver");
            player_random.move_point = 0;
        }
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
    }
}