using UnityEngine;
using System.Collections;

public class X1X2X3 : MonoBehaviour {

    [SerializeField]
	private GameObject X1;
    [SerializeField]
    private GameObject X2;
    [SerializeField]
    private GameObject X3;

	// Use this for initialization
	void Start () {
		X1.gameObject.SetActive(true);
		X2.gameObject.SetActive(false);
		X3.gameObject.SetActive(false);
	}

	public void X1damage()
	{
		X1.gameObject.SetActive(true);
		X2.gameObject.SetActive(false);
		X3.gameObject.SetActive(false);
	}

	public void X2damage()
	{
		X1.gameObject.SetActive(false);
		X2.gameObject.SetActive(true);
		X3.gameObject.SetActive(false);
	}

	public void X3damage()
	{
		X1.gameObject.SetActive(false);
		X2.gameObject.SetActive(false);
		X3.gameObject.SetActive(true);
	}
}
