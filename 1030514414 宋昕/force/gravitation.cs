using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravitation : MonoBehaviour {

	public float k = 1.0f;
	Vector3 r_off;
	Vector3 ps;


	// Use this for initialization
	void Start () {
		//ps = new Vector3 (Screen.width/2.0f,Screen.height/2.0f, 0);

	}

	// Update is called once per frame

	void Update ()
	{

		//Vector3 pos1 = Input.mousePosition;
		//t = Time.realtimeSinceStartup;

		SpriteRenderer sr = GetComponent<SpriteRenderer> ();
		Rigidbody2D rb = GetComponent<Rigidbody2D> ();

		if (rb == null) {
			return;
		}

		//if(Input.GetMouseButton(1))
		ps = Input.mousePosition;

		Vector3 Pos = transform.localPosition;
		Vector3 pos = trans (Pos);
		r_off = ps - pos;

		Vector3 r_direc = r_off.normalized;
		float r = r_off.magnitude; 
		Vector3 G = k * r_direc * (1.0f/r*r);
		rb.AddForce (G,ForceMode2D.Impulse);

		Color c = sr.color;
		c.a = 1.0f / r*r;
		sr.color = c;

		//Debug.Log (Pos);



	}

	Vector3 trans(Vector3 pos){
		pos.x = pos.x + 1.80f;
		pos.y = pos.y + 0.90f;
		pos.x = pos.x * (Screen.width/3.60f);
		pos.y = pos.y * (Screen.height/1.30f);
		return pos;
	}
}
