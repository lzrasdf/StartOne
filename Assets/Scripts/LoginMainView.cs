using UnityEngine;
using System.Collections;

public class LoginMainView : MonoBehaviour {

	public GameObject[] obj;
	GameObject Button_1;
	GameObject Button_2;
	GameObject Button_3;
	GameObject Button_4;
	GameObject Image;

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
		Button_1 = GameObject.Find("Button_1");
		Button_2 = GameObject.Find("Button_2");
		Button_3 = GameObject.Find("Button_3");
		Button_4 = GameObject.Find("Button_4");
		Image = GameObject.Find("Image");

		Awake();
		DoSomeThing();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void DoSomeThing () {
		UIEventListener Lis_Btn_1 = Button_1.gameObject.AddComponent<UIEventListener>();  
		UIEventListener Lis_Btn_2 = Button_2.gameObject.AddComponent<UIEventListener>();  
		UIEventListener Lis_Btn_3 = Button_3.gameObject.AddComponent<UIEventListener>();  
		UIEventListener Lis_Btn_4 = Button_4.gameObject.AddComponent<UIEventListener>();  

		Lis_Btn_1.OnClick += delegate(GameObject gb)  
		{  
			double x = Image.transform.localPosition.x;
			double y = Image.transform.localPosition.y;
			double z = Image.transform.localPosition.z;
			Debug.Log(x); 
			Debug.Log(y); 
			//Image.transform.localposition = Vector3(x - 10, y, z); 
			Image.GetComponent<Transform>().position = Vector3(x - 10, y, z);
		};
		Lis_Btn_2.OnClick += delegate(GameObject gb)  
		{  
			Debug.Log("2"); 
		};
		Lis_Btn_3.OnClick += delegate(GameObject gb)  
		{  
			Debug.Log("3"); 
		};
		Lis_Btn_4.OnClick += delegate(GameObject gb)  
		{  
			Debug.Log("4"); 
		};

	}
}
