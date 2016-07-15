using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class CanvasSetup : NetworkBehaviour
{

    void Start()
    {
        if (isLocalPlayer)
        {
            GetComponent<Canvas>().enabled = true;
        }
    }
}
