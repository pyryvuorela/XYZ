using UnityEngine;
using System.Collections;

public class BackgroundScroll : MonoBehaviour {

	public float speed = 0.5f;

	void Update () {
		Vector2 offset = new Vector2 (speed * Time.time, 0);
		GetComponent<Renderer>().material.mainTextureOffset = offset;﻿
	}
}
