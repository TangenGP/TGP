using UnityEngine;
using System.Collections;

public class IfDead : MonoBehaviour
{
	Health health;
	ShopSystem shop;

	void Start ()
	{
		health = GetComponent<Health>();
		shop = GetComponent<ShopSystem>();
	}
	
	void Update()
	{
		if (health.alive == false)
		{
			shop.Gold += 10;
		}
	}
}
