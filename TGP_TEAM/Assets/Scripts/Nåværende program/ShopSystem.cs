using UnityEngine;
using System.Collections;

public class ShopSystem : MonoBehaviour
{

	public GameObject ShopWall;
	public GameObject gun;
	public GameObject petgun;

	public int amountSubtracted;
	public int prisForAmmo;

	void Start () {
		ShopWall.gameObject.SetActive(false);
		gun.gameObject.SetActive(true);
		petgun.gameObject.SetActive(true);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Shop")
		{
			ShopWall.gameObject.SetActive(true);
			gun.gameObject.SetActive(false);
			petgun.gameObject.SetActive(false);
		}
			
	}
	void OnTriggerExit2D()
	{
		ShopWall.gameObject.SetActive(false);
		gun.gameObject.SetActive(true);
		petgun.gameObject.SetActive(true);
	}

	/*public void laserskuddx1()
	{
		GetComponent<Weapon> ().laserSkudd (prisForAmmo);
		GetComponent<playerMoney>().subtractMoney(amountSubtracted);
	}

	public void laserskuddx2()
	{
		
	}*/
}
