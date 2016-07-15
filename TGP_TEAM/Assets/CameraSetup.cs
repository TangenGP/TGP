using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class CameraSetup : NetworkBehaviour
{

    void Start()
    {
        if (isLocalPlayer)
        {
            GetComponent<CameraFollow>().enabled = true;
            GetComponent<GunRotation>().enabled = true;
        }
    }
}
