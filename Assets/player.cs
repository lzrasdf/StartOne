using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

    private Transform m_Transform;
    private Transform came;

	// Use this for initialization
	void Start () {
         m_Transform = gameObject.GetComponent<Transform>();
         came = Camera.main.transform;
	}
	
	// Update is called once per frame
	void Update () {
        float speed = 0.01f;

        if (Input.GetKey (KeyCode.W))
        {
            m_Transform.Translate(-1 * speed,0,0);
            //m_Transform.Translate(Vector3.forward * speed, Camera.main.transform);
        }

        if (Input.GetKey(KeyCode.A))
        {
            m_Transform.Translate(0,0,-1 * speed);
            //m_Transform.Translate(Vector3.left * speed, Camera.main.transform);
        }

        if (Input.GetKey(KeyCode.D))
        {
            m_Transform.Translate(0, 0, 1 * speed);
            //m_Transform.Translate(Vector3.right * speed, Camera.main.transform);
        }

        if (Input.GetKey(KeyCode.S))
        {
            m_Transform.Translate(1 * speed, 0, 0);
            //m_Transform.Translate(Vector3.back * speed, Camera.main.transform);
        }
	}
}
