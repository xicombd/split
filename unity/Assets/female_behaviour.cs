﻿using UnityEngine;
using System.Collections;

public class female_behaviour : MonoBehaviour {
	
	public Rigidbody rigidbody;
	
	public float speed = -10;
	
	// Use this for initialization
	void Start () {
		rigidbody.velocity = new Vector3 (speed, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
