using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
	public string unitName;
	public int unitLevel;

	public int damage;

	public int maxHP;
	public int currentHP;
	SoundManager SoundEffect;
	public string storeItemName;

	public int ADDHeal = 0;
	
	public bool TakeEdamage(int dmg)
    {
        currentHP -= dmg;
        if (currentHP <= 0)
            return true;
        else
            return false;
    }

	public bool TakeDamage(int dmg)
	{
        currentHP -= dmg + GameObject.Find("Battle System").GetComponent<BattleDamageCalc>().FinalDamageWithCard();

		if (currentHP <= 0)
			return true;
		else
			return false;
	}

	public void Heal()
	{
		currentHP += GameObject.Find("Battle System").GetComponent<BattleDamageCalc>().FinalHealWithCard();
		if (currentHP > maxHP)
			currentHP = maxHP;
	}

	public void UseStore()
	{
		storeItemName = GameObject.Find("player").GetComponent<PlayerClickItem>().clickItemName;
		if (storeItemName == "PlusMax")
		{
			currentHP -= 10;
		}
		if (storeItemName == "PlusMiddle")
		{
			currentHP -= 7;
		}
		if (storeItemName == "PlusSmall")
		{
			currentHP -= 4;
		}
	}

	public void HealField()
    {
		SoundEffect = GameObject.Find("SoundManager").GetComponent<SoundManager>();
		SoundEffect.SFXPlay("audioHealCenter");
		ADDHeal = (maxHP / 10) * 3;
		currentHP += ADDHeal;
		if(currentHP >= maxHP)
        {
			currentHP = maxHP;
        }
	}
}
