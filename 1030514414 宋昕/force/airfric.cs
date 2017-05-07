using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class airfric : MonoBehaviour {

	Vector3 pos,vec,acc;
	Vector3 fa,fa_a;
	public float k = 1.0f;
	float m = 0.1f;
	float g = 1.0f;
	public bool 是否产生空气阻力;

	// Use this for initialization
	void Start () {
		fa = new Vector3 (0,0,0);
		acc.x = g;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (是否产生空气阻力) {
			if (fa_a.x < g) {
				fa.x = k * (vec.x * vec.x) * -1.0f * 0.01f;
				fa_a.x += fa.x / m;
				acc.x += (fa_a.x + g);
				vec.x += acc.x * 0.01f;
				pos.x += vec.x * 0.01f;

			} else
				pos.x += 0.0f;
			
		} else {
			vec.x += acc.x * 0.01f;
			pos.x += vec.x * 0.01f;
		}


		transform.Translate(pos * Time.deltaTime ,Space.World);

		//Vector3 a = transform.localPosition;
		//Debug.Log (fa_a.x);
	}
		
}
