﻿using UnityEngine;
using System.Collections;

public class SceneManager4 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            Application.LoadLevel("Stage3");
        }
    }
}
