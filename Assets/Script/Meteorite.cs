using UnityEngine;
using System.Collections;

public class Meteorite : Enemy
{
    public GameObject m_meteorite;
    public int m_touchedUpperLimit;

    override public void StartTouching(float x, float y)
    {
        m_touchTime ++;
        SetFingerPosition(x, y);
        if(m_touchTime >= m_touchedUpperLimit)
        {
            SetActive(false);
        }
    }

    override public void Touching(float x, float y)
    {

    }

    override public void EndTouching(float x, float y)
    {

    }

    override public void Move()
    {
        
    }

    public void SetActive(bool active)
    {
        m_meteorite.SetActive(active);
    }
}
