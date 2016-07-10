using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerMoney : MonoBehaviour {

	public int money;
	public Text moneyText;

	void Start () 
	{
		money = 100;
		moneyText.text = money.ToString ();
	}

	void Update () 
	{
	
	}

	public void addMoney(int moneyToAdd)
	{
		money += moneyToAdd;
		moneyText.text = money.ToString ();
	}

	public void subtractMoney(int moneyToSubtract)
	{
		if (money - moneyToSubtract < 0) {
			Debug.Log ("You don't have enough money");
		} else {
			money -= moneyToSubtract;
			moneyText.text = money.ToString ();
		}
	}
}
