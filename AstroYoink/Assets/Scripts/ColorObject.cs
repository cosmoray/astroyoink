﻿using UnityEngine;
using System.Collections;

public class ColorObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.G))
		{
			gameObject.renderer.material.color = Color.red;
		
	}
		if(Input.GetKeyUp(KeyCode.G))
		{
			gameObject.renderer.material.color = Color.gray;
		}
}
}
