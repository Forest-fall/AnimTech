﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class son1 : par {
	public float _TorquePower = 1.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public override void Update () {
		base.Update ();
		selfbehaviour ();
	}

	void selfbehaviour(){
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		rb.AddTorque (Random.value * _TorquePower);//添加力矩;
		
	}
}
