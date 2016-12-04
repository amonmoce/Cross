using UnityEngine;
using System.Collections;

public class FingerTouch : MonoBehaviour {
    public GameObject m_fingerPosition;
    private float m_fieldPositionZ = 10f;
    private float m_fieldFarPositionZ = 100f;
    private float m_fingerPositionX;
    private float m_fingerPositionY;
	// Use this for initialization
	void Start () {
        m_fingerPosition.transform.position = new Vector3(0, 0, m_fieldFarPositionZ);
    }
	
	// Update is called once per frame
	void Update () {
        DesktopInput();

    }

    public void DesktopInput()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePositionOnNearPlane = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, m_fieldPositionZ));
            m_fingerPosition.transform.position = mousePositionOnNearPlane;
            m_fingerPositionX = mousePositionOnNearPlane.x;
            m_fingerPositionY = mousePositionOnNearPlane.y;
        }

        if (Input.GetMouseButtonUp(0))
        {
            float positionX = m_fingerPosition.transform.position.x;
            float positionY = m_fingerPosition.transform.position.y;
            m_fingerPosition.transform.position = new Vector3(positionX, positionY, m_fieldFarPositionZ);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            other.GetComponent<Enemy>().StartTouching(m_fingerPositionX, m_fingerPositionY);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Enemy")
        {
            other.GetComponent<Enemy>().Touching(m_fingerPositionX, m_fingerPositionY);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Enemy")
        {
            other.GetComponent<Enemy>().EndTouching(m_fingerPositionX, m_fingerPositionY);
        }
    }
}
