using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zd : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}


	public float r;
	public float ang;
	public float V;
	public float A;
	// Update is called once per frame
	void Update () {
		float t = Time.realtimeSinceStartup;
		float g = 0.4f;
		A = (-1 * g) / r * Mathf.Sin (ang);
		V += A;
		ang += V;
		Vector3 LocalPos = transform.localPosition;
		transform.localPosition = new Vector3 (r * Mathf.Sin (ang)+LocalPos.x, r * Mathf.Cos (ang)+LocalPos.y, 0.0f);


	}


}
