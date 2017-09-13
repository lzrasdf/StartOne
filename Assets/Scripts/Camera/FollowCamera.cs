using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {
	GameObject follow_root;
	// Use this for initialization
	void Start () {
		follow_root = GameObject.Find("Sphere1");    //摄像机要跟随的人物
		transform.Rotate (Vector3.left * 3);
	}
	
	// Update is called once per frame
	void Update () {
		//transform.rotation= follow_root.transform.rotation;
		transform.position= follow_root.transform.position;

		transform.Translate (Vector3.back * 5);
		transform.Translate (Vector3.up * 2);

		//transform.Rotate (Vector3.down * 15);
	}
}

