using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ShopMainView : MonoBehaviour {
	GameObject btn_1;
	GameObject bg;
	// Use this for initialization
	void Start () {
		btn_1 = GameObject.Find("btn_1");
		bg = GameObject.Find("bg");

		UIEventListener Lis_btn_1 = btn_1.gameObject.AddComponent<UIEventListener>();  
		Lis_btn_1.OnClick += delegate(GameObject gb)  
		{  
			/*Application.LoadLevel("third");*///切换到场景Scene_2  
			SceneManager.LoadScene("LoginMainView");
		};
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
