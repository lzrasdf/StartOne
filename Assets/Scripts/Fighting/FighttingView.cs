using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighttingView : MonoBehaviour {
	GameObject btn_up;
	GameObject btn_down;
	GameObject btn_left;
	GameObject btn_right;
	GameObject Sphere1;

	void AddEvent () {
		UIEventListener Lis_up = btn_up.gameObject.AddComponent<UIEventListener>();  
		UIEventListener Lis_down = btn_down.gameObject.AddComponent<UIEventListener>();  
		UIEventListener Lis_left = btn_left.gameObject.AddComponent<UIEventListener>();  
		UIEventListener Lis_right = btn_right.gameObject.AddComponent<UIEventListener>();  
/*transform.Translate (Vector3.forward * Time.deltaTime * 5);
transform.Translate (Vector3.back * Time.deltaTime * 5);
transform.Translate (Vector3.up * Time.deltaTime * 5);
transform.Translate (Vector3.down * Time.deltaTime * 5);
transform.Translate (Vector3.left * Time.deltaTime * 5);
transform.Translate (Vector3.right * Time.deltaTime * 5);*/
		Lis_up.OnClick += delegate(GameObject gb)  
		{  
			Sphere1.transform.Translate (Vector3.forward * Time.deltaTime * 5);
		};
		Lis_down.OnClick += delegate(GameObject gb)  
		{  
			Sphere1.transform.Translate (Vector3.back * Time.deltaTime * 5);
		};
		Lis_left.OnClick += delegate(GameObject gb)  
		{  
			Sphere1.transform.Translate (Vector3.left * Time.deltaTime * 5);
		};
		Lis_right.OnClick += delegate(GameObject gb)  
		{  
			Sphere1.transform.Translate (Vector3.right * Time.deltaTime * 5);
		};
	}

	// Use this for initialization
	void Start () {
		btn_up 		= GameObject.Find("btn_up");
		btn_down 	= GameObject.Find("btn_down");
		btn_left 	= GameObject.Find("btn_left");
		btn_right 	= GameObject.Find("btn_right");

		Sphere1		= GameObject.Find("Sphere1");

		AddEvent();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W))
		{
			Sphere1.transform.Translate (Vector3.forward * Time.deltaTime * 5);
		}
		if(Input.GetKey(KeyCode.W))
		{
			Sphere1.transform.Translate (Vector3.back * Time.deltaTime * 5);
		}
		if(Input.GetKey(KeyCode.W))
		{
			Sphere1.transform.Translate (Vector3.left * Time.deltaTime * 5);
		}
		if(Input.GetKey(KeyCode.W))
		{
			Sphere1.transform.Translate (Vector3.right * Time.deltaTime * 5);
		}
	}

	void OnGUI() {

	}
}


//transform.Translate (Vector3.forward * Time.deltaTime);
//transform.Translate (0, Time.deltaTime, 0, Space.World);
//Camera.main.transform

//transform.Rotate(0, 2, 0);
//transform.Rotate(Vector3.up * 1, Space.World);