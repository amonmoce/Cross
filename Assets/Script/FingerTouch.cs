using UnityEngine;
using System.Collections;

public class FingerTouch : MonoBehaviour {
    public GameObject m_fingerPosition;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        DesktopInput();

    }

    public void DesktopInput()
    {
        if (Input.GetMouseButton(0))
        {
            float temp = m_fingerPosition.transform.position.z;
            Vector3 mousePositionOnNearPlane = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
            m_fingerPosition.transform.position = mousePositionOnNearPlane;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if(other.name == "Cube")
        {
            other.GetComponent<Obstacle>().Touched();
        }
    }

}
