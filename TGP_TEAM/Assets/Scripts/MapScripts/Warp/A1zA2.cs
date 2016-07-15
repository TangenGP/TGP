using UnityEngine;
using System.Collections;

public class A1zA2 : MonoBehaviour
{
	public void ChangeScene(string sceneName)
	{
		Application.LoadLevel(sceneName);
	}
}
