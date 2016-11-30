using UnityEngine;
using System.Collections;

public class Barrier : Obstacle
{
    public GameObject test;
    private bool isStop = true;

    override public void Touched()
    {
        Debug.Log("OK");
        isStop = false;
    }

    override public void Move()
    {
        if (isStop)
        {
            test.transform.position = new Vector3(test.transform.position.x + 0.01f, test.transform.position.y + 0.01f, test.transform.position.z);
        }
    }
}
