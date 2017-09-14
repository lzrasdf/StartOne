using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	// Use this for initialization
	void Start () {
		 Debug.Log( (int)Days.Tue );
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W))
		{
			//前进
			MoveTemp(GlobalDirection.Str_Forward);

		}else if(Input.GetKey(KeyCode.S))	
		{
			//后退
			MoveTemp(GlobalDirection.Str_Back);
		}

		if(Input.GetKey(KeyCode.A))
		{
			//前左
			MoveTemp(GlobalDirection.Str_Left);

		}else if(Input.GetKey(KeyCode.D))	
		{
			//后右
			MoveTemp(GlobalDirection.Str_Right);
		}

		if(Input.GetKey(KeyCode.Q))
		{
			//左旋转

			RotateTemp(0.5,GlobalDirection.Str_Left);

		}else if(Input.GetKey(KeyCode.E))
		{
			//右旋转
			RotateTemp(0.5,GlobalDirection.Str_Right);

		}

	}

	/*
		移动控制具体实现
	*/
	public void MoveTemp (string dir) {
		//transform.Translate (Vector3.forward * Time.deltaTime);
		if (dir == GlobalDirection.Str_Forward)
			transform.Translate (Vector3.forward * Time.deltaTime * 5);
		if (dir == GlobalDirection.Str_Back)
			transform.Translate (Vector3.back * Time.deltaTime * 5);
		if (dir == GlobalDirection.Str_Up)
			transform.Translate (Vector3.up * Time.deltaTime * 5);
		if (dir == GlobalDirection.Str_Down)
			transform.Translate (Vector3.down * Time.deltaTime * 5);
		if (dir == GlobalDirection.Str_Left)
			transform.Translate (Vector3.left * Time.deltaTime * 5);
		if (dir == GlobalDirection.Str_Right)
			transform.Translate (Vector3.right * Time.deltaTime * 5);
	}

	public void RotateTemp(double speed , string dir){
		//transform.Rotate(Vector3.up * 1, Space.World);
		if (dir == GlobalDirection.Str_Forward)
			transform.Rotate (Vector3.forward * 1);
		if (dir == GlobalDirection.Str_Back)
			transform.Rotate (Vector3.back * 1);
		if (dir == GlobalDirection.Str_Up)
			transform.Rotate (Vector3.up * 1);
		if (dir == GlobalDirection.Str_Down)
			transform.Rotate (Vector3.down * 1);
		if (dir == GlobalDirection.Str_Left)
			transform.Rotate (Vector3.left * 1);
		if (dir == GlobalDirection.Str_Right)
			transform.Rotate (Vector3.right * 1);
	}

	Vector3 GetLocalPosition(){
		float x = transform.localPosition.x;
		float y = transform.localPosition.x;
		float z = transform.localPosition.x;
		Vector3 result = new Vector3 (x, y, z);
		return result;
	}

	Vector3 GetPosition(){
		float x = transform.position.x;
		float y = transform.position.x;
		float z = transform.position.x;
		Vector3 result = new Vector3 (x, y, z);
		return result;
	}
}
