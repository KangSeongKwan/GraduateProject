using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : Stat
{
	private void Start()
	{
		_hp = 100;
		_maxHp = 100;
		_attack = 10;
	}
}
