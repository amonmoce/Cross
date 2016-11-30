using UnityEngine;
using System.Collections;

public class ProtectedObject : MonoBehaviour {
    public GameObject m_protectedObject;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Move();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag != "FingerPosition")
        {
            Debug.Log("End Game");
        }
        else
        {
            Debug.Log(other.name);
        }
    }

    void Move()
    {
        m_protectedObject.transform.position = new Vector3(m_protectedObject.transform.position.x, m_protectedObject.transform.position.y + 0.01f, m_protectedObject.transform.position.z);
    }
}
