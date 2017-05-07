using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class compo2 : MonoBehaviour {

	compo1 c1 = new compo1();
	public float _最大步长 = 0.01f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void Update () {
		SpriteRenderer sr;
		sr = GetComponent<SpriteRenderer> ();
		behave1 (sr);
		transform.position += behave2 ();
		behave3 ();

		
	}
	public void behave1(SpriteRenderer sr){
		c1.behave1 (sr);
	}

	public Vector3 behave2(){
		return c1.behave2 ();
	}

	public void behave3(){
		Vector3 当前尺寸 = transform.localScale;
		float x方向当前尺寸 = 当前尺寸.x;
		float y方向当前尺寸 = 当前尺寸.y;

		float x尺寸变化极限 = x方向当前尺寸 * _最大步长;
		float y尺寸变化极限 = y方向当前尺寸 * _最大步长;

		float x尺寸随机变化量 = Random.Range (-x尺寸变化极限, x尺寸变化极限);
		float y尺寸随机变化量 = Random.Range (-y尺寸变化极限, y尺寸变化极限);

		Vector3 随机变化后的尺寸 = new Vector3 (
			x方向当前尺寸 + x尺寸随机变化量,
			y方向当前尺寸 + y尺寸随机变化量);

		transform.localScale = 随机变化后的尺寸;
		
	}



}
