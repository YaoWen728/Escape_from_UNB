using UnityEngine;
using System.Collections;

public class SceneManager1 : MonoBehaviour {

    private float timer;

	// Use this for initialization
	void Start () {

        timer = 4.0f;
        timer -= Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {

        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Application.LoadLevel("Chapter1");
        } 
	
	}
}
