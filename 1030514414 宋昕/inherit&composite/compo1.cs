using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class compo1 : MonoBehaviour {


	void Start () {
	}
	
	// Update is called once per frame
	public void Update () {
		SpriteRenderer sr;
		sr = GetComponent<SpriteRenderer> ();
		behave1 (sr);
		transform.position += behave2 ();
	}
	public void behave1(SpriteRenderer sr){
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

	public Vector3 behave2(){
		float ss = 0.01f;
		float x = Random.Range (-ss, ss);
		float y = Random.Range (-ss, ss);
		return new Vector3 (x, y, 0.0f);

	}




		
}
