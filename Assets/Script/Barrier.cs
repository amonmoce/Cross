using UnityEngine;
using System.Collections;

public class Barrier : Enemy
{
    public GameObject test;

    override public void StartTouching(float x, float y)
    {
        m_touchTime = 1;
        SetFingerPosition(x, y);
    }

    override public void Touching(float x, float y)
    {

    }

    override public void EndTouching(float x, float y)
    {
        
    }

    override public void Move()
    {
        if (m_touchTime == 0)
        {
            test.transform.position = new Vector3(test.transform.position.x + 0.01f, test.transform.position.y + 0.01f, test.transform.position.z);
        }
    }
}
