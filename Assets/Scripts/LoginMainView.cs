using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoginMainView : MonoBehaviour {

	public GameObject[] obj;
	GameObject btn_single;
	GameObject btn_shop;
	GameObject bg;

    void Awake()
    {
   		/*string[] objarray = { "Button_1", "Button_2", "Button_3", "Button_4", "Image" };
        foreach (string j in objarray )
        {
        	GameObject obj.j = GameObject.Find(j);
        }*/
        /*GameObject Button_1 = GameObject.Find("Button_1");
        GameObject Button_2 = GameObject.Find("Button_2");
        GameObject Button_3 = GameObject.Find("Button_3");
        GameObject Button_4 = GameObject.Find("Button_4");
        GameObject Image = GameObject.Find("Image");*/
    }

	// Use this for initialization
	void Start () {
		btn_single = GameObject.Find("btn_single");
		btn_shop = GameObject.Find("btn_shop");
		bg = GameObject.Find("bg");

		Awake();
		DoSomeThing();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void DoSomeThing () {
		UIEventListener Lis_single = btn_single.gameObject.AddComponent<UIEventListener>();  
		UIEventListener Lis_shop = btn_shop.gameObject.AddComponent<UIEventListener>();  

		Lis_single.OnClick += delegate(GameObject gb)  
		{  
			/*double x = Image.transform.localPosition.x;
			double y = Image.transform.localPosition.y;
			double z = Image.transform.localPosition.z;
			Debug.Log(x); 
			Debug.Log(y); */
			 Debug.Log("Single"); 
		};
		Lis_shop.OnClick += delegate(GameObject gb)  
		{  
			SceneManager.LoadScene("ShopMainView");
		};
	}
}