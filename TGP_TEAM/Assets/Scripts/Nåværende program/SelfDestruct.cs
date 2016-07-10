﻿using UnityEngine;
using System.Collections;

public class SelfDestruct : MonoBehaviour {

	public float timer = 0.5f;

	void Update () {
		timer -= Time.deltaTime;

		if(timer <= 0) {
			Destroy(gameObject);
        }
	}
}
