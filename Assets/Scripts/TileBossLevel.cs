﻿using UnityEngine;
using System.Collections;

public class TileBossLevel : MonoBehaviour {
	float xscalefactor = 1f;

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Renderer> ().material.mainTextureScale =
			new Vector3 (transform.localScale.x/xscalefactor, transform.localScale.z);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
