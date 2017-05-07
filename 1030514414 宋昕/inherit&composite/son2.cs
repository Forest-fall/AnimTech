using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class son2 :par {

	float y,x;
	float T = 120.0f;
	public float a = 0.02f;
	public float b = 1.1f;
	float angle;
	Vector3 pos;
	Vector3 center;
	float t = 0;

	void Start () {

		y = 0;
		x = 0;
		center = Input.mousePosition;
	}

	// Update is called once per frame
	public override void Update () {
		base.Update ();
		selfbehaviour ();

	}
	void selfbehaviour(){
		angle = 2.0f * Mathf.PI * (t / T);
		t ++;

		Debug.Log (center);

		float r = rose (angle);
		pos = PolarToXY(center,angle,r);

		transform.localPosition = pos;

	}
	Vector3 PolarToXY(Vector3 center,float angle,float r){
		float x, y;
		center = transScreenToPosition(center);
		x = r * Mathf.Cos (angle) + center.x;
		y = r * Mathf.Sin (angle) + center.y;
		Vector3 pos = new Vector3 (x , y ,0.0f);
		return pos;
	}

	float rose(float angle){
		float r_rose = a * Mathf.Cos (2.0f * angle) * 0.1f;
		return r_rose;
	}

	Vector3 transScreenToPosition(Vector3 pos){
		pos.x = pos.x / (Screen.width/3.60f);
		pos.y = pos.y / (Screen.height/1.30f);
		pos.x = pos.x - 1.80f;
		pos.y = pos.y - 0.90f;
		return pos;
	}


}
