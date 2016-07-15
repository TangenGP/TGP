using UnityEngine;
using System.Collections;

public class A1zA2portal : MonoBehaviour
{

	public GameObject portalButton;

	void Start()
	{
		portalButton.gameObject.SetActive(false);

	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "portal")
		{
			portalButton.gameObject.SetActive(true);
		}

	}
	void OnTriggerExit2D()
	{
		portalButton.gameObject.SetActive(false);
	}
}