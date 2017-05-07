using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Normal_Scale : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float x = NextGaussian(0.2f,0.2f,0,0.1f);
		float y = NextGaussian(0.3f,0.3f,0,0.1f);
		float xx = AT_MathUtil.map (
			x, 
			0.0f,0.1f,
			-1.0f,1.0f);
		float yy = AT_MathUtil.map (
			y, 
			0.0f,0.1f,
			-1.0f,1.0f);
		transform.localScale += new Vector3(xx*0.01f,yy*0.01f,0);

		alpha ();
	}

	void alpha(){

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

	float NextGaussian()
	{
		float v1, v2, s;
		do {
			v1 = 2.0f * Random.Range(0f,1f) - 1.0f;
			v2 = 2.0f * Random.Range(0f,1f) - 1.0f;
			s = v1 * v1 + v2 * v2;
		} while (s >= 1.0f || s == 0f);

		s = Mathf.Sqrt((-2.0f * Mathf.Log(s)) / s);

		return v1 * s;

	}

	float NextGaussian(float u, float o)
	{
		return u + NextGaussian() * o;
	}

	float NextGaussian(float u, float o, float min, float max)
	{
		float x;
		do{
			x = NextGaussian(u,o);
		} while (x < min || x > max);
		return x;
	}

}

