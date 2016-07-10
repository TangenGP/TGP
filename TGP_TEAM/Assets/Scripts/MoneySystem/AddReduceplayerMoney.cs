using UnityEngine;
using System.Collections;

public class AddReduceplayerMoney : MonoBehaviour {

	public GameObject cam;

	// Use this for initialization
	void Start () {
		cam.GetComponent<Health> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown("Fire1")) {
			cam.GetComponent<playerMoney> ().addMoney (5);
		}
		
		if (Input.GetButtonDown("Fire2")) {
			cam.GetComponent<playerMoney> ().subtractMoney (5);
		}
	}
}
