using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Die : MonoBehaviour
{
    Unit unit;
    void Update()
    {
        unit = GameObject.Find("PlayerStat").GetComponent<Unit>();        
        if(unit.currentHP <= 0)
        {
            SceneManager.LoadScene("GameOver");
            player_random.move_point = 0;
        }
    }
}
