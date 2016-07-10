using UnityEngine;
using System.Collections;

public class ShopSystem : MonoBehaviour
{
	public int Gold = 100;
    public int Stone = 0;
    public int Wood = 0;

	public GameObject ShopWall;
	public GameObject gun;
	public GameObject petgun;

	void Start () {
		Gold = 100;
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

	public void wood()
	{
		if (Gold >= 10)
		{
			Gold -= 10;
			Wood += 5;
		}
	}

	public void stone()
	{
		if (Gold >= 15) {
			Gold -= 15;
			Stone += 5;
		}
	}
}
