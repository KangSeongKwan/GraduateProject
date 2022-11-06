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
		int a;
		storeItemName = GameObject.Find("player").GetComponent<PlayerClickItem>().clickItemName;
		a = int.Parse(storeItemName.Substring(4, 1));

		switch(a)
        {
			case 9:
				currentHP -= 10;
				break;

			case 8:
				currentHP -= 7;
				break;

			case 7:
				currentHP -= 7;
				break;

			case 6:
				currentHP -= 7;
				break;

			case 5:
				currentHP -= 4;
				break;

			case 4:
				currentHP -= 4;
				break;

			case 3:
				currentHP -= 4;
				break;

			case 2:
				currentHP -= 4;
				break;

			case 1:
				currentHP -= 4;
				break;
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
