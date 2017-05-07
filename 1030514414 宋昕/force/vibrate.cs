using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vibrate : MonoBehaviour {

	float y,x;
	float T = 120.0f;
	public float a = 0.02f;
	public float b = 1.1f;
	float angle;
	Vector3 pos;
	Vector3 center;
	public bool 玫瑰,心,螺线,星星;
	float t = 0;

	// Use this for initialization
	void Start () {
		
		y = 0;
		x = 0;
		center = Input.mousePosition;
	}

	// Update is called once per frame
	void Update () {

		//t = Time.frameCount;

	    angle = 2.0f * Mathf.PI * (t / T);
		t ++;
		
		Debug.Log (center);

		if (玫瑰) {
			float r = rose (angle);
			pos = PolarToXY(center,angle,r);
		} 
		else if (心) {
			float r = heart (angle);
			pos = PolarToXY(center,angle,r);
		}  
		else if (螺线) {
			float r = screw (angle);
			pos = PolarToXY(center,angle,r);
		}
		else if (星星) {
			Vector3 cc = transScreenToPosition(center);
			x = a * Mathf.Cos (angle) * Mathf.Cos (angle) * Mathf.Cos (angle) * 0.1f  + cc.x ;
			y = a * Mathf.Sin (angle) * Mathf.Sin (angle) * Mathf.Sin (angle) * 0.1f  + cc.y; 
			pos = new Vector3 (x, y,0.0f);

		}
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

	float heart(float angle){ 
		float r_heart = a * (1 - Mathf.Cos (angle)) * 0.1f;
		return r_heart;
	}

	float screw(float angle){ 
		float r_screw =(a * angle + b) * 0.01f;
		return r_screw;
	}


	Vector3 transScreenToPosition(Vector3 pos){
		pos.x = pos.x / (Screen.width/3.60f);
		pos.y = pos.y / (Screen.height/1.30f);
		pos.x = pos.x - 1.80f;
		pos.y = pos.y - 0.90f;
		return pos;
	}
}

