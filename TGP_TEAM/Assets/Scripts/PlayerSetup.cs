using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class PlayerSetup : NetworkBehaviour {

	void Start ()
    {
	    if(isLocalPlayer)
        {
            GetComponent<PlayerMovement>().enabled = true;
            GetComponent<Health>().enabled = true;
            GetComponent<playerMoney>().enabled = true;
            GetComponent<X1X2X3>().enabled = true;
            GetComponent<A1zA2portal>().enabled = true;
            GetComponent<GunRotation>().enabled = true;
            GetComponent<Weapon>().enabled = true;
            GetComponent<ShopSystem>().enabled = true;
        }
	}
}
