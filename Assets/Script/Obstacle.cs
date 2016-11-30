﻿using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
    
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Move();
    }

    public virtual void Touched()
    {
        
    }

    public virtual void Move()
    {
        
    }
}