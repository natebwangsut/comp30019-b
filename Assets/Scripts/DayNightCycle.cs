﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour {
	
	public float speed = (2*Mathf.PI) * 5;

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		// Assume x-axis is the of West-East
		transform.RotateAround(Vector3.zero, Vector3.right, speed * Time.deltaTime);
		transform.LookAt(Vector3.zero);
	}
}