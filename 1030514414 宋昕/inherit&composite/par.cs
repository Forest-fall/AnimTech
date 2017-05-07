using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public   class par : MonoBehaviour {

	public  float _LifeSpan = 10.0f;
	public float _ForcePower = 1.0f;
	public float _ForceOffset = 1.0f;


	void Start () {

	}


	public virtual void Update () {
		LifeSpan ();
		ApplyRandomForce ();
		BaseBehaviour ();
	}

    public void LifeSpan ()
	{
		_LifeSpan -= Time.deltaTime;
		if (_LifeSpan < 0.0f) {
			Destroy (gameObject);
		}
	}


	void ApplyRandomForce ()
	{
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();
		rb.AddForceAtPosition (_ForcePower * Random.insideUnitCircle, _ForceOffset * Random.insideUnitCircle);
	}

	void BaseBehaviour ()
	{
		
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
