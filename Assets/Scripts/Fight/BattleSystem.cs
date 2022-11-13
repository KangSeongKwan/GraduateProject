using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class BattleSystem : MonoBehaviour
{

	public GameObject playerPrefab;
	//public GameObject enemyPrefab;
	public List<GameObject> EnemyList = new List<GameObject>();
	public static List<GameObject> AttkCard = new List<GameObject>();
	public static List<GameObject> HealCard = new List<GameObject>();
	public Transform playerBattleStation;
	public Transform enemyBattleStation;
	Unit playerUnit;
	Unit enemyUnit;
	SoundManager SoundEffect;
	public Text dialogueText;

	public BattleHUD playerHUD;
	public BattleHUD enemyHUD;

	public BattleState state;
    public int EnemyHP = 0;
	public int i;
	BattleCamActiver battleCam;

    // Start is called before the first frame update
    void Start()
    {
		GameObject.Find("Battle System").SetActive(false);
    }

	IEnumerator SetupBattle()
	{
		GameObject.Find("Light2D").SetActive(false);
		GameObject.Find("count").SetActive(false);
		GameObject playerGO = Instantiate(playerPrefab, playerBattleStation);
		playerUnit = GameObject.Find("PlayerStat").GetComponent<Unit>();
		GameObject enemyGO = Instantiate(EnemyList[i], enemyBattleStation);
		enemyUnit = enemyGO.GetComponent<Unit>();

		dialogueText.text = "A wild " + enemyUnit.unitName + " approaches...";

		playerHUD.SetHUD(playerUnit);
		enemyHUD.SetHUD(enemyUnit);
		yield return new WaitForSeconds(2f);

		state = BattleState.PLAYERTURN;
		PlayerTurn();
	}

	IEnumerator PlayerAttack()
	{
		SoundEffect = GameObject.Find("SoundManager").GetComponent<SoundManager>();
		bool isDead = enemyUnit.TakeDamage(playerUnit.damage);
        BattleDamageCalc BDC = GameObject.Find("Battle System").GetComponent<BattleDamageCalc>();
        enemyHUD.SetHP(enemyUnit.currentHP);
		dialogueText.text = "The attack damage : " + BDC.FinalDamage;

		if(BDC.FinalDamage <= 50)
        {
			SoundEffect.SFXPlay("audioPAttack");
		}
		else if(BDC.FinalDamage > 50)
        {
			SoundEffect.SFXPlay("audioPBigAtk");
		}
		else if(BDC.FinalDamage > 100)
        {
			SoundEffect.SFXPlay("audioPCriticalAtk");
		}

		yield return new WaitForSeconds(2f);

		if (isDead)
		{
			state = BattleState.WON;
			EndBattle();
		} else
		{
			state = BattleState.ENEMYTURN;
			StartCoroutine(EnemyTurn());
		}
	}

	IEnumerator EnemyTurn()
	{
		dialogueText.text = enemyUnit.unitName + " attacks! (damage : " + enemyUnit.damage + ")";
		SoundEffect = GameObject.Find("SoundManager").GetComponent<SoundManager>();
		SoundEffect.SFXPlay("audioEAttack");
		yield return new WaitForSeconds(1f);

		bool isDead = playerUnit.TakeEdamage(enemyUnit.damage);

		playerHUD.SetHP(playerUnit.currentHP);

		yield return new WaitForSeconds(1f);

		if(isDead)
		{
			state = BattleState.LOST;
			EndBattle();
		} else
		{
			state = BattleState.PLAYERTURN;
			PlayerTurn();
		}

	}

	void EndBattle()
	{
		BattleCount Bcount = GameObject.Find("BattleCount").GetComponent<BattleCount>();
		GameObject.Find("Canvas").transform.Find("count").gameObject.SetActive(true);
		if (state == BattleState.WON)
		{
			Bcount.battleCount++;
			if (Bcount.battleCount >= 3)
			{
				GameObject.Find("player").GetComponent<ItemSelect>().CreateReward();
				Bcount.battleCount = 0;
			}
			dialogueText.text = "You won the battle!";
			GameObject.Find("CameraManager").GetComponent<CameraManager>().mainCameraOn();
			GameObject.Find("player").GetComponent<PlayerClickItem>().enabled = true;
			GameObject.Find("LIGHT2D").transform.Find("Light2D").gameObject.SetActive(true);
			GameObject.Find("player").GetComponent<Click_Move>().click = true;
			GameObject.Find("player").GetComponent<player_random>().roll = true;
		}
		else if (state == BattleState.LOST)
		{
			dialogueText.text = "You were defeated.";
			Invoke("GameOverScene", 2f);
		}
	}

	void PlayerTurn()
	{
		dialogueText.text = "Choose an action!!";
		Debug.Log("Player turn");
        GameObject.Find("Battle System").GetComponent<BattleSelectItem>().SetCard();
    }

	IEnumerator PlayerHeal()
	{
		playerUnit.Heal();
		SoundEffect = GameObject.Find("SoundManager").GetComponent<SoundManager>();
		SoundEffect.SFXPlay("audioPHeal");
		BattleDamageCalc BDC = GameObject.Find("Battle System").GetComponent<BattleDamageCalc>();
        playerHUD.SetHP(playerUnit.currentHP);
		dialogueText.text = "Heal : " + BDC.FinalHeal;

		yield return new WaitForSeconds(2f);

		state = BattleState.ENEMYTURN;
		StartCoroutine(EnemyTurn());
	}

	public void OnAttackButton()
	{
		if (state != BattleState.PLAYERTURN)
			return;

		StartCoroutine(PlayerAttack());
	}

	public void OnHealButton()
	{
		if (state != BattleState.PLAYERTURN)
			return;

		StartCoroutine(PlayerHeal());
	}

	public void StartBattle()
    {
		state = BattleState.START;
		StartCoroutine(SetupBattle());
	}
    public void Update()
    {
        EnemyHP = enemyUnit.currentHP;
    }

	public void GameOverScene()
	{
		SceneManager.LoadScene("GameOver");
	}
}
