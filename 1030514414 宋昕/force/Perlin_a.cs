using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perlin_a : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		SpriteRenderer sr;
		sr = GetComponent<SpriteRenderer> ();
		Color c = sr.color;
		float x = Random.Range (0,2.0f);
		float y = Random.Range (0,2.0f);
		float a = c.a * Mathf.PerlinNoise (x,y);
		float pro = Mathf.PerlinNoise (0.03f,0.05f);
		if (a > 0.1f && a < 0.6f) {
			c.a = a;
			sr.color = c;
		} else {
			c.a = 0.01f;
			sr.color = c;
			
		}
		
	}
}
