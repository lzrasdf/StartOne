using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

    private Transform m_Transform;
	// Use this for initialization
	void Start () {
        m_Transform = gameObject.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        //m_Transform.transform.rotation.z = 0;
        Quaternion a = gameObject.transform.rotation;
        //Unity不允许直接设置Rotation中X.Y.Z的值，我们需要这样做才可以：

        //先来一个Quaternion :
        Quaternion quate = Quaternion.identity;

        //然后设置他的角度:
        quate.eulerAngles = new Vector3(a.x, a.y, 0); // 表示设置x轴方向旋转了45度

        //最后再把quate付给你要操作的Gameobject：
        m_Transform.transform.rotation = quate;
    }
}
