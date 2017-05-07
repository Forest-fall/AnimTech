using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyframe : MonoBehaviour {

	public AnimationCurve _X,_Y;
	public AnimationCurve _alpha;
	public AnimationCurve _scale;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		SpriteRenderer sr;
		sr = GetComponent<SpriteRenderer> ();
		Color c = sr.color;
		//Color current_c = GetComponent<SpriteRenderer> ().color;

		float t = Time.realtimeSinceStartup;

		//float mx = (float)Input.mousePosition.x * 0.01f;

		float y = _Y.Evaluate (t) ;
		float x = _X.Evaluate (t);
		transform.localPosition = new Vector3 (x-2.0f, y-1.0f, 0);


		float a = _alpha.Evaluate (t);
		c.a= a;
		sr.color = c;
		Debug.Log (sr.color.a);

		float scale = _scale.Evaluate (t);
		transform.localScale = new Vector2 (scale,scale);

		
	}
}
